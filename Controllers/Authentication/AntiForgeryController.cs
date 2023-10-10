using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;

[Route("api/xsrf-token")]
[ApiController]
public class AntiForgeryController : Controller
{
    private IAntiforgery _antiforgery;

    public AntiForgeryController(IAntiforgery antiforgery)
    {
        _antiforgery = antiforgery;
    }

    // [IgnoreAntiforgeryToken]
    // public IActionResult Get()
    // {
    // 	var tokens = _antiforgery.GetAndStoreTokens(HttpContext);
    // 	return Ok(tokens.RequestToken);
    // }
}