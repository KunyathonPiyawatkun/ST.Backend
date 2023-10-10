

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NLog;
using ST_API.Extensions.Middleware;
using ST_API.Interfaces;
using System.Globalization;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Antiforgery;
using Alert.Api.Hubs;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Features;
using ST_API.Service;
using ST_API.EF.PTT_CRSR;

#region start builder
var builder = WebApplication.CreateBuilder(args);
ConfigurationManager Configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;
#endregion

#region Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
#endregion

#region Database
builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<PTT_CRSREntity>(options =>
                {
                    options.UseSqlServer(builder.Configuration.GetValue<string>("ConnectionStrings:STConnectionStrings"),
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(maxRetryCount: 15, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                    });
                });
#endregion

#region Swagger
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new OpenApiInfo { Title = "ST API", Version = "v1" });
    x.AddSecurityDefinition("bearerAuth", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."
    });
    x.AddSecurityRequirement(new OpenApiSecurityRequirement
     {

         {
            new OpenApiSecurityScheme
              {
                 Reference = new OpenApiReference
                 {
                   Type = ReferenceType.SecurityScheme,
                   Id = "bearerAuth"
                 }
            },new string[] {}
         }
     });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    x.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
#endregion

#region Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
{
    option.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = Configuration["jwt:Issuer"],
        ValidateAudience = true,
        ValidAudience = Configuration["jwt:Audience"],
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero, // disable delay when token is expire delay timeout
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["jwt:Key"]))
    };
    //�Ѻ Token �ҡ SignalR 
    #region
    //option.Events = new JwtBearerEvents
    //{
    //    OnMessageReceived = context =>
    //    {
    //        var accessToken = context.Request.Query["access_token"];

    //        // If the request is for our hub...
    //        var path = context.HttpContext.Request.Path;
    //        if (!string.IsNullOrEmpty(accessToken))
    //        {
    //            // Read the token out of the query string
    //            context.Token = accessToken;
    //        }
    //        return Task.CompletedTask;
    //    }
    //};
    #endregion
});
#endregion

#region antiforgery
// Extension method comes from the `Microsoft.AspNetCore.Antiforgery` package
builder.Services.AddAntiforgery(options =>
{
    options.HeaderName = "X-XSRF-TOKEN";
    options.SuppressXFrameOptionsHeader = false;
});

// builder.Services.AddScoped<IAuthentication, AuthenticationSevice>();

#endregion

#region  UploadFile unlimit Size
builder.Services.Configure<FormOptions>(options =>
{
    options.ValueLengthLimit = int.MaxValue;
    options.MultipartBodyLengthLimit = long.MaxValue;
    options.MultipartHeadersLengthLimit = int.MaxValue;
});
#endregion

#region  Json Options
builder.Services.AddMvc().AddJsonOptions(options => { options.JsonSerializerOptions.PropertyNamingPolicy = null; });
builder.Services.AddSignalR().AddJsonProtocol(option =>
{
    option.PayloadSerializerOptions.WriteIndented = false;
});
#endregion

#region Policy
// builder.Services.AddCors(option => option.AddDefaultPolicy(policy =>
// { policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod(); }));

builder.Services.AddCors(options => options.AddPolicy("corsPolicy", builder =>
        {
            builder.WithOrigins("http://localhost:3000", "https://localhost:3000", "https://localhost:7239", "https://localhost:5001/lngintranet/LoginAD")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
        }
       )
      );
#endregion

#region  Logger Manager
builder.Services.AddSingleton<ILoggerManager, LoggerManager>();
#endregion

#region DB 
builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<PTT_CRSREntity>(options =>
                {
                    options.UseSqlServer(builder.Configuration.GetValue<string>("ConnectionStrings:ST_IntranetEntity"),
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(maxRetryCount: 15, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                    });
                });
#endregion

#region Add interface Service Controller To Model

#endregion

#region Memorybuilder.Services.AddMemoryCache();
builder.Services.AddDistributedMemoryCache();
#endregion

#region app setting
var app = builder.Build();

#region Configure the HTTP request pipeline.
app.Use(async (context, next) =>
      {
          context.Response.Headers.Add("X-Frame-Options", "DENY");
          context.Response.Headers.Add("Cache-Control", "no-cache, no-store, must-revalidate");
          context.Response.Headers.Add("Pragma", "no-cache");
          context.Response.Headers.Add("Expires", "0");
          await next(context);
      });
#endregion

if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");
app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, app.Environment.IsDevelopment() ? "wwwroot" : "wwwroot")),
});
app.UseRouting();
app.UseCors("corsPolicy");

// global error handler 
app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(x => x.MapControllers());
//app.MapHub<ProgressEvent>("SignalREvent"); // Signa lR

app.MapGet("antiforgery/token", (IAntiforgery forgeryService, HttpContext context) =>
{
    var tokens = forgeryService.GetAndStoreTokens(context);
    context.Response.Cookies.Append("XSRF-TOKEN", tokens.RequestToken!,
      new CookieOptions { HttpOnly = false });

    return Results.Ok();
}).RequireAuthorization().RequireCors("corsPolicy");

app.MapControllerRoute(
 name: "default",
 pattern: "{controller}/{action=Index}/{id?}");

app.MapHub<AlertHub>("/SignalRAlert");

app.Run();
#endregion