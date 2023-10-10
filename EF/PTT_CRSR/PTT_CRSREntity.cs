using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ST_API.EF.PTT_CRSR;

public partial class PTT_CRSREntity : DbContext
{
    public PTT_CRSREntity()
    {
    }

    public PTT_CRSREntity(DbContextOptions<PTT_CRSREntity> options)
        : base(options)
    {
    }

    public virtual DbSet<TB_Alert> TB_Alert { get; set; }

    public virtual DbSet<TB_Approve> TB_Approve { get; set; }

    public virtual DbSet<TB_Area> TB_Area { get; set; }

    public virtual DbSet<TB_Area_Agriculture> TB_Area_Agriculture { get; set; }

    public virtual DbSet<TB_Area_Agriculture_History> TB_Area_Agriculture_History { get; set; }

    public virtual DbSet<TB_Area_Budget> TB_Area_Budget { get; set; }

    public virtual DbSet<TB_Area_Budget_History> TB_Area_Budget_History { get; set; }

    public virtual DbSet<TB_Area_BundleType> TB_Area_BundleType { get; set; }

    public virtual DbSet<TB_Area_BundleType_History> TB_Area_BundleType_History { get; set; }

    public virtual DbSet<TB_Area_CommunityType> TB_Area_CommunityType { get; set; }

    public virtual DbSet<TB_Area_CommunityType_History> TB_Area_CommunityType_History { get; set; }

    public virtual DbSet<TB_Area_File> TB_Area_File { get; set; }

    public virtual DbSet<TB_Area_Geography> TB_Area_Geography { get; set; }

    public virtual DbSet<TB_Area_Geography_History> TB_Area_Geography_History { get; set; }

    public virtual DbSet<TB_Area_History> TB_Area_History { get; set; }

    public virtual DbSet<TB_Area_Image> TB_Area_Image { get; set; }

    public virtual DbSet<TB_Area_Indicator> TB_Area_Indicator { get; set; }

    public virtual DbSet<TB_Area_Indicator_History> TB_Area_Indicator_History { get; set; }

    public virtual DbSet<TB_Area_Occupation> TB_Area_Occupation { get; set; }

    public virtual DbSet<TB_Area_OccupationGroup> TB_Area_OccupationGroup { get; set; }

    public virtual DbSet<TB_Area_PTT_Project> TB_Area_PTT_Project { get; set; }

    public virtual DbSet<TB_Area_PTT_Project_History> TB_Area_PTT_Project_History { get; set; }

    public virtual DbSet<TB_Area_Product> TB_Area_Product { get; set; }

    public virtual DbSet<TB_Area_Product_History> TB_Area_Product_History { get; set; }

    public virtual DbSet<TB_Area_ResultBudget> TB_Area_ResultBudget { get; set; }

    public virtual DbSet<TB_Area_ResultBudget_History> TB_Area_ResultBudget_History { get; set; }

    public virtual DbSet<TB_Area_ResultIndicator> TB_Area_ResultIndicator { get; set; }

    public virtual DbSet<TB_Area_ResultIndicator_History> TB_Area_ResultIndicator_History { get; set; }

    public virtual DbSet<TB_Area_ResultScore> TB_Area_ResultScore { get; set; }

    public virtual DbSet<TB_Area_ResultScore_History> TB_Area_ResultScore_History { get; set; }

    public virtual DbSet<TB_Area_ScoreBefore> TB_Area_ScoreBefore { get; set; }

    public virtual DbSet<TB_Area_ScoreBefore_History> TB_Area_ScoreBefore_History { get; set; }

    public virtual DbSet<TB_Area_Stakeholders> TB_Area_Stakeholders { get; set; }

    public virtual DbSet<TB_Area_StakeholdersType> TB_Area_StakeholdersType { get; set; }

    public virtual DbSet<TB_Area_StakeholdersType_History> TB_Area_StakeholdersType_History { get; set; }

    public virtual DbSet<TB_Area_Stakeholders_History> TB_Area_Stakeholders_History { get; set; }

    public virtual DbSet<TB_Banner> TB_Banner { get; set; }

    public virtual DbSet<TB_BundleType_Mapping> TB_BundleType_Mapping { get; set; }

    public virtual DbSet<TB_EmailLog> TB_EmailLog { get; set; }

    public virtual DbSet<TB_LogEmail> TB_LogEmail { get; set; }

    public virtual DbSet<TB_LogLogin> TB_LogLogin { get; set; }

    public virtual DbSet<TB_Project> TB_Project { get; set; }

    public virtual DbSet<TB_Project_AgencyCooperation> TB_Project_AgencyCooperation { get; set; }

    public virtual DbSet<TB_Project_AgencyCooperation_History> TB_Project_AgencyCooperation_History { get; set; }

    public virtual DbSet<TB_Project_AgencySecondary> TB_Project_AgencySecondary { get; set; }

    public virtual DbSet<TB_Project_AgencySecondary_History> TB_Project_AgencySecondary_History { get; set; }

    public virtual DbSet<TB_Project_Budget> TB_Project_Budget { get; set; }

    public virtual DbSet<TB_Project_Budget_History> TB_Project_Budget_History { get; set; }

    public virtual DbSet<TB_Project_File> TB_Project_File { get; set; }

    public virtual DbSet<TB_Project_History> TB_Project_History { get; set; }

    public virtual DbSet<TB_Project_Indicator> TB_Project_Indicator { get; set; }

    public virtual DbSet<TB_Project_Indicator_History> TB_Project_Indicator_History { get; set; }

    public virtual DbSet<TB_Project_ResultBudget> TB_Project_ResultBudget { get; set; }

    public virtual DbSet<TB_Project_ResultBudget_History> TB_Project_ResultBudget_History { get; set; }

    public virtual DbSet<TB_Project_ResultIndicator> TB_Project_ResultIndicator { get; set; }

    public virtual DbSet<TB_Project_ResultIndicator_History> TB_Project_ResultIndicator_History { get; set; }

    public virtual DbSet<TB_Project_ResultScore> TB_Project_ResultScore { get; set; }

    public virtual DbSet<TB_Project_ResultScore_History> TB_Project_ResultScore_History { get; set; }

    public virtual DbSet<TB_Project_SDGsSecondary> TB_Project_SDGsSecondary { get; set; }

    public virtual DbSet<TB_Project_SDGsSecondary_History> TB_Project_SDGsSecondary_History { get; set; }

    public virtual DbSet<TB_Project_ScoreBefore> TB_Project_ScoreBefore { get; set; }

    public virtual DbSet<TB_Project_ScoreBefore_History> TB_Project_ScoreBefore_History { get; set; }

    public virtual DbSet<TB_Request> TB_Request { get; set; }

    public virtual DbSet<TB_Request_History> TB_Request_History { get; set; }

    public virtual DbSet<TB_Schedule> TB_Schedule { get; set; }

    public virtual DbSet<TB_Setup_UpdateProgress> TB_Setup_UpdateProgress { get; set; }

    public virtual DbSet<TB_User> TB_User { get; set; }

    public virtual DbSet<TM_Agency> TM_Agency { get; set; }

    public virtual DbSet<TM_Config> TM_Config { get; set; }

    public virtual DbSet<TM_ConfigFlow> TM_ConfigFlow { get; set; }

    public virtual DbSet<TM_Data> TM_Data { get; set; }

    public virtual DbSet<TM_DataType> TM_DataType { get; set; }

    public virtual DbSet<TM_DisplayAdminMenu> TM_DisplayAdminMenu { get; set; }

    public virtual DbSet<TM_District> TM_District { get; set; }

    public virtual DbSet<TM_Indicator> TM_Indicator { get; set; }

    public virtual DbSet<TM_LoginType> TM_LoginType { get; set; }

    public virtual DbSet<TM_Menu> TM_Menu { get; set; }

    public virtual DbSet<TM_Occupation> TM_Occupation { get; set; }

    public virtual DbSet<TM_Provinces> TM_Provinces { get; set; }

    public virtual DbSet<TM_RequestType> TM_RequestType { get; set; }

    public virtual DbSet<TM_SDGs> TM_SDGs { get; set; }

    public virtual DbSet<TM_Stakeholders> TM_Stakeholders { get; set; }

    public virtual DbSet<TM_Status> TM_Status { get; set; }

    public virtual DbSet<TM_Subdistrict> TM_Subdistrict { get; set; }

    public virtual DbSet<TM_UserGroup> TM_UserGroup { get; set; }

    public virtual DbSet<TM_UserGroupPermisson> TM_UserGroupPermisson { get; set; }

    public virtual DbSet<TM_UserLoginType> TM_UserLoginType { get; set; }

    public virtual DbSet<TM_UserMappingGroup> TM_UserMappingGroup { get; set; }

    public virtual DbSet<TM_UserMappingRole> TM_UserMappingRole { get; set; }

    public virtual DbSet<TM_UserPermission> TM_UserPermission { get; set; }

    public virtual DbSet<TM_UserRole> TM_UserRole { get; set; }

    public virtual DbSet<TM_UserRolePermission> TM_UserRolePermission { get; set; }

    public virtual DbSet<TM_UserType> TM_UserType { get; set; }

    public virtual DbSet<TM_UserTypeMappingLogin> TM_UserTypeMappingLogin { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=\n147.50.231.79;database=PTT_CRSR;User ID=PTT_CRSR;Password=cPTT_CRSR;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_CI_AS");

        modelBuilder.Entity<TB_Alert>(entity =>
        {
            entity.HasKey(e => e.nAlertID);

            entity.Property(e => e.nAlertID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางการแจ้งเตือนการอัพเดต Progress");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDate)
                .HasComment("วันที่ส่งอีเมลแจ้งเตือน")
                .HasColumnType("date");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nRound).HasComment("รอบที่");
            entity.Property(e => e.nUpdateProgressID).HasComment("รหัสรอบการแจ้งเตือน");
        });

        modelBuilder.Entity<TB_Approve>(entity =>
        {
            entity.HasKey(e => e.nRequestID);

            entity.Property(e => e.nRequestID).ValueGeneratedNever();
            entity.Property(e => e.sDV_ID)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasComment("รหัสพนักงานของผู้จัดการส่วน ที่อนุมัติใบงาน");
            entity.Property(e => e.sDV_Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sVP_ID)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasComment("รหัสพนักงานของผู้จัดการฝ่าย ที่อนุมัติใบงาน");
            entity.Property(e => e.sVP_Name)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area>(entity =>
        {
            entity.HasKey(e => e.AreaID);

            entity.Property(e => e.AreaID).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dEndDate)
                .HasComment("ยังไม่ใช้ฟิลด์นี้ ทำเผื่อไว้")
                .HasColumnType("date");
            entity.Property(e => e.dStartDate)
                .HasComment("ยังไม่ใช้ฟิลด์นี้ ทำเผื่อไว้")
                .HasColumnType("date");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.nAreaTypeID).HasComment("ประเภทพื้นที่");
            entity.Property(e => e.nAverageIncome).HasComment("รายได้เฉลี่ย");
            entity.Property(e => e.nDistrictID).HasComment("รหัสอำเภอ");
            entity.Property(e => e.nHousehold).HasComment("จำนวนครัวเรือน");
            entity.Property(e => e.nLatitude)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.nLongitude)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.nPopulation).HasComment("จำนวนประชากร");
            entity.Property(e => e.nProvinceID).HasComment("รหัสจังหวัด");
            entity.Property(e => e.nStatus).HasComment("True =  พื้นที่  Activate, False= ปิดพื้นที่");
            entity.Property(e => e.sAnotherAgency)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("หน่วยงานอื่น ๆ ที่ทับซ้อนกันในพื้นที่");
            entity.Property(e => e.sAreaTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทพื้นที่ (TM_Data)");
            entity.Property(e => e.sBundleTypeFormal)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("รายละเอียดประเภทการรวมกลุ่มแบบทางการ");
            entity.Property(e => e.sBundleTypeInformal)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("รายละเอียดประเภทการรวมกลุ่มแบบไม่ทางการ");
            entity.Property(e => e.sComment)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("ความคิดเห็น ความคาดหวัง ข้อกังวลของชุมชน");
            entity.Property(e => e.sConnection)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("ความเชื่อมโยงกับ ปตท.");
            entity.Property(e => e.sCooperation)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("ความร่วมมือหน่วยงาน/องค์กรอื่น ๆ");
            entity.Property(e => e.sCulture)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("วัฒนธรรม");
            entity.Property(e => e.sDistrictNameTH)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sExplainMore)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("คำอธิบายเพิ่มเติมประเภทชุมชน");
            entity.Property(e => e.sPathMap)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.sProvinceNameTH)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sRisk)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.sSubDistrictID)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComment("รหัสตำบล");
            entity.Property(e => e.sSubdistrictNameTH)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sTravel)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("การท่องเที่ยว");
        });

        modelBuilder.Entity<TB_Area_Agriculture>(entity =>
        {
            entity.HasKey(e => e.nAreaAgricultureID);

            entity.Property(e => e.nAreaAgricultureID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางข้อมูลการเกษตรของพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAgricultureID).HasComment("รหัสข้อมูลการเกษตร (TM_Data)");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.sAgricultureName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_Agriculture_History>(entity =>
        {
            entity.HasKey(e => e.nAreaAgricultureID_His);

            entity.Property(e => e.nAreaAgricultureID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAgricultureID).HasComment("รหัสข้อมูลการเกษตร (TM_Data)");
            entity.Property(e => e.nAreaAgricultureID).HasComment("รหัสหลักตารางข้อมูลการเกษตรของพื้นที่");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.sAgricultureName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_Budget>(entity =>
        {
            entity.HasKey(e => e.nAreaBudgetID).HasName("PK_TB_BudgetArea");

            entity.Property(e => e.nAreaBudgetID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางข้อมูลงบประมาณตั้งต้นของพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaBudget).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.sDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_Budget_History>(entity =>
        {
            entity.HasKey(e => e.nAreaBudgetID_His);

            entity.Property(e => e.nAreaBudgetID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaBudget).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.nAreaBudgetID).HasComment("รหัสหลักตารางข้อมูลงบประมาณตั้งต้นของพื้นที่");
            entity.Property(e => e.sDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_BundleType>(entity =>
        {
            entity.HasKey(e => e.nAreaBundleTypeID).HasName("PK_Area_BundleType");

            entity.Property(e => e.nAreaBundleTypeID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักข้อมูลประเทภการรวมกลุ่มของพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nBundleTypeID).HasComment("รหัสประเภทการรวมกลุ่ม");
            entity.Property(e => e.nNatureGroupingID).HasComment("รหัสลักษณะการรวมกลุ่ม");
            entity.Property(e => e.sBundleTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sNatureGroupingName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_BundleType_History>(entity =>
        {
            entity.HasKey(e => e.nAreaBundleTypeID_His);

            entity.Property(e => e.nAreaBundleTypeID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaBundleTypeID).HasComment("รหัสหลักข้อมูลประเทภการรวมกลุ่มของพื้นที่");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nBundleTypeID).HasComment("รหัสประเภทการรวมกลุ่ม");
            entity.Property(e => e.nNatureGroupingID).HasComment("รหัสลักษณะการรวมกลุ่ม");
            entity.Property(e => e.sBundleTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sNatureGroupingName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_CommunityType>(entity =>
        {
            entity.HasKey(e => e.nAreaCommunityTypeID);

            entity.Property(e => e.nAreaCommunityTypeID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางประเภทชุมชน");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nCommunityTypeID).HasComment("รหัสประเภทชุมชน (TM_Data)");
            entity.Property(e => e.sCommunityTypeName).HasComment("ชื่อประเภทชุมชน (TM_Data)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_CommunityType_History>(entity =>
        {
            entity.HasKey(e => e.nAreaCommunityTypeID_His);

            entity.Property(e => e.nAreaCommunityTypeID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaCommunityTypeID).HasComment("รหัสหลักตารางประเภทชุมชน");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nCommunityTypeID).HasComment("รหัสประเภทชุมชน (TM_Data)");
            entity.Property(e => e.sCommunityTypeName).HasComment("ชื่อประเภทชุมชน (TM_Data)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_File>(entity =>
        {
            entity.HasKey(e => e.nAreaFileID);

            entity.Property(e => e.nAreaFileID)
                .ValueGeneratedNever()
                .HasComment("รหัสไฟล์ของเอกสารพื้่นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nFileTypeID).HasComment("ประเภทเอกสาร");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sFilename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.sPath)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.sSystemFilename)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_Geography>(entity =>
        {
            entity.HasKey(e => e.nAreaGeographyID);

            entity.Property(e => e.nAreaGeographyID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางลักษณะทางภูมิศาสตร์ ");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nGeographyID).HasComment("ลักษณะทางภูมิศาสตร์ (TM_Data)");
            entity.Property(e => e.sGeographyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sOther)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_Geography_History>(entity =>
        {
            entity.HasKey(e => e.nAreaGeographyID_His);

            entity.Property(e => e.nAreaGeographyID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaGeographyID).HasComment("รหัสหลักตารางลักษณะทางภูมิศาสตร์ ");
            entity.Property(e => e.nGeographyID).HasComment("ลักษณะทางภูมิศาสตร์ (TM_Data)");
            entity.Property(e => e.sGeographyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sOther)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_History>(entity =>
        {
            entity.HasKey(e => e.AreaID_His);

            entity.Property(e => e.AreaID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dEndDate)
                .HasComment("ยังไม่ใช้ฟิลด์นี้ ทำเผื่อไว้")
                .HasColumnType("date");
            entity.Property(e => e.dStartDate)
                .HasComment("ยังไม่ใช้ฟิลด์นี้ ทำเผื่อไว้")
                .HasColumnType("date");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.nAreaTypeID).HasComment("ประเภทพื้นที่");
            entity.Property(e => e.nAverageIncome).HasComment("รายได้เฉลี่ย");
            entity.Property(e => e.nDistrictID).HasComment("รหัสอำเภอ");
            entity.Property(e => e.nHousehold).HasComment("จำนวนครัวเรือน");
            entity.Property(e => e.nLatitude)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.nLongitude)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.nPopulation).HasComment("จำนวนประชากร");
            entity.Property(e => e.nProvinceID).HasComment("รหัสจังหวัด");
            entity.Property(e => e.nReferanceAreaID).HasComment("อ้างอิงจากรหัสพื้นที่ ที่เป็นพื้นที่เดียวกัน กรณีมีมากกว่า 1 ให้อ้างอิงจากพื้นที่แรกเสมอ โดยหากมีพื้นที่เดียวกันในโครงการเดียวกันเปิดอยู่ ต้องห้ามเพิ่มพื้นที่เดิมซ้ำ");
            entity.Property(e => e.sAnotherAgency)
                .IsUnicode(false)
                .HasComment("หน่วยงานอื่น ๆ ที่ทับซ้อนกันในพื้นที่");
            entity.Property(e => e.sAreaTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทพื้นที่ (TM_Data)");
            entity.Property(e => e.sBundleTypeFormal)
                .IsUnicode(false)
                .HasComment("รายละเอียดประเภทการรวมกลุ่มแบบทางการ");
            entity.Property(e => e.sBundleTypeInformal)
                .IsUnicode(false)
                .HasComment("รายละเอียดประเภทการรวมกลุ่มแบบไม่ทางการ");
            entity.Property(e => e.sComment)
                .IsUnicode(false)
                .HasComment("ความคิดเห็น ความคาดหวัง ข้อกังวลของชุมชน");
            entity.Property(e => e.sConnection)
                .IsUnicode(false)
                .HasComment("ความเชื่อมโยงกับ ปตท.");
            entity.Property(e => e.sCooperation)
                .IsUnicode(false)
                .HasComment("ความร่วมมือหน่วยงาน/องค์กรอื่น ๆ");
            entity.Property(e => e.sCulture)
                .IsUnicode(false)
                .HasComment("วัฒนธรรม");
            entity.Property(e => e.sDistrictNameTH)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sExplainMore)
                .IsUnicode(false)
                .HasComment("คำอธิบายเพิ่มเติมประเภทชุมชน");
            entity.Property(e => e.sPathMap)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.sProvinceNameTH)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sRisk).IsUnicode(false);
            entity.Property(e => e.sSubDistrictID)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComment("รหัสตำบล");
            entity.Property(e => e.sSubdistrictNameTH)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sTravel)
                .IsUnicode(false)
                .HasComment("การท่องเที่ยว");
        });

        modelBuilder.Entity<TB_Area_Image>(entity =>
        {
            entity.HasKey(e => e.nAreaImageID);

            entity.Property(e => e.nAreaImageID).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaImageTypeID).HasComment("ประเภทรูปภาพ");
            entity.Property(e => e.nRoundUpdate).HasComment("รอบที่ Update Progress");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.sExpireName)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.sImagePath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sSystemName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_Indicator>(entity =>
        {
            entity.HasKey(e => e.nAreaIndecatorID);

            entity.Property(e => e.nAreaIndecatorID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางตัวชี้วัดของพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nIndicatorID).HasComment("รหัสตัวชี้วัด (TM_Stakeholders)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_Indicator_History>(entity =>
        {
            entity.HasKey(e => e.nAreaIndecatorID_His);

            entity.Property(e => e.nAreaIndecatorID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nAreaIndecatorID).HasComment("รหัสหลักตารางตัวชี้วัดของพื้นที่");
            entity.Property(e => e.nIndicatorID).HasComment("รหัสตัวชี้วัด (TM_Stakeholders)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_Occupation>(entity =>
        {
            entity.HasKey(e => e.nAreaOccupationID);

            entity.Property(e => e.nAreaOccupationID)
                .ValueGeneratedNever()
                .HasComment("รหัสตารางเก็บอาชีพพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nOccupationID).HasComment("รหัสอาชีพ");
            entity.Property(e => e.nOccupationgGroupID).HasComment("รหัสกลุ่มอาชีพ");
            entity.Property(e => e.sOccupationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่ออาชีพ");
        });

        modelBuilder.Entity<TB_Area_OccupationGroup>(entity =>
        {
            entity.HasKey(e => e.nAreaOccupationGroupID).HasName("PK_TM_OccupationGroup");

            entity.Property(e => e.nAreaOccupationGroupID)
                .ValueGeneratedNever()
                .HasComment("รหัสตารางกลุ่มอาชีพ");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nOccupationGroupID).HasComment("รหัสกลุ่มอาชีพ");
            entity.Property(e => e.nOccupationGroupName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อกลุ่มอาชีพ");
            entity.Property(e => e.nOccupationTypeID).HasComment("รหัสประเภทกลุ่มอาชีพ (หลัก/รอง) (TM_Data.nDataTypeID = 3)");
        });

        modelBuilder.Entity<TB_Area_PTT_Project>(entity =>
        {
            entity.HasKey(e => e.nAreaPTTProjectID);

            entity.Property(e => e.nAreaPTTProjectID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางโครงการพัฒนาของ ปตท. และกลุ่ม ปตท. ในอดีต");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้่นที่");
            entity.Property(e => e.nPTTProjectID).HasComment("รหัสโครงการพัฒนาของ ปตท. (TM_Data)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sPTTProjectName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อโครงการพัฒนาของ ปตท. (TM_Data)");
        });

        modelBuilder.Entity<TB_Area_PTT_Project_History>(entity =>
        {
            entity.HasKey(e => e.nAreaPTTProjectID_His);

            entity.Property(e => e.nAreaPTTProjectID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้่นที่");
            entity.Property(e => e.nAreaPTTProjectID).HasComment("รหัสหลักตารางโครงการพัฒนาของ ปตท. และกลุ่ม ปตท. ในอดีต");
            entity.Property(e => e.nPTTProjectID).HasComment("รหัสโครงการพัฒนาของ ปตท. (TM_Data)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sPTTProjectName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อโครงการพัฒนาของ ปตท. (TM_Data)");
        });

        modelBuilder.Entity<TB_Area_Product>(entity =>
        {
            entity.HasKey(e => e.nAreaProductID);

            entity.Property(e => e.nAreaProductID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางข้อมูลผลิตภัณฑ์ของพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sOther)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sProductName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_Product_History>(entity =>
        {
            entity.HasKey(e => e.nAreaProductID_His);

            entity.Property(e => e.nAreaProductID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaProductID).HasComment("รหัสหลักตารางข้อมูลผลิตภัณฑ์ของพื้นที่");
            entity.Property(e => e.sOther)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sProductName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_ResultBudget>(entity =>
        {
            entity.HasKey(e => e.nAreaResultBudgetID);

            entity.Property(e => e.nAreaResultBudgetID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางงบประมาณที่ใช้จริงที่ผูกกับรายพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nResultBudget).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(5000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_ResultBudget_History>(entity =>
        {
            entity.HasKey(e => e.nAreaResultBudgetID_His);

            entity.Property(e => e.nAreaResultBudgetID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nAreaResultBudgetID).HasComment("รหัสหลักตารางงบประมาณที่ใช้จริงที่ผูกกับรายพื้นที่");
            entity.Property(e => e.nResultBudget).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(5000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_ResultIndicator>(entity =>
        {
            entity.HasKey(e => e.nAreaResultIndicatorID);

            entity.Property(e => e.nAreaResultIndicatorID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางผลลัพธ์ตัวชี้วัดพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nAroundUpdate).HasComment("รอบการอัพเดต");
            entity.Property(e => e.nIndicatorID).HasComment("รหัสตัวชี้วัด (TM_Stakeholders)");
            entity.Property(e => e.nResultIndecator).HasComment("ผลลัพธ์");
            entity.Property(e => e.nYear).HasComment("ปี");
            entity.Property(e => e.sDescroption)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sIndicatorName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_ResultIndicator_History>(entity =>
        {
            entity.HasKey(e => e.nAreaResultIndicatorID_His).HasName("PK_TB_Area_ResultIndicato_Historyr");

            entity.Property(e => e.nAreaResultIndicatorID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nAreaResultIndicatorID).HasComment("รหัสหลักตารางผลลัพธ์ตัวชี้วัดพื้นที่");
            entity.Property(e => e.nAroundUpdate).HasComment("รอบการอัพเดต");
            entity.Property(e => e.nIndicatorID).HasComment("รหัสตัวชี้วัด (TM_Stakeholders)");
            entity.Property(e => e.nResultIndecator).HasComment("ผลลัพธ์");
            entity.Property(e => e.nYear).HasComment("ปี");
            entity.Property(e => e.sDescroption)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sIndicatorName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Area_ResultScore>(entity =>
        {
            entity.HasKey(e => e.nAreaResultScoreID);

            entity.Property(e => e.nAreaResultScoreID).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nScoreTypeID).HasComment("รหัสประเภทคะแนน (TM_data.nDataTypeID = 2)");
            entity.Property(e => e.sDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sScoreTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทคะแนน (TM_data)");
        });

        modelBuilder.Entity<TB_Area_ResultScore_History>(entity =>
        {
            entity.HasKey(e => e.nAreaResultScoreID_His);

            entity.Property(e => e.nAreaResultScoreID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nScoreTypeID).HasComment("รหัสประเภทคะแนน (TM_data)");
            entity.Property(e => e.sDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sScoreTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทคะแนน (TM_data)");
        });

        modelBuilder.Entity<TB_Area_ScoreBefore>(entity =>
        {
            entity.HasKey(e => e.nAreaScoreBeforeID);

            entity.Property(e => e.nAreaScoreBeforeID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางคะแนนก่อนการดำเนินงานที่ผูกกับพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nProjectScoreBefore).HasComment("คะแนนก่อนดำเนินการ");
            entity.Property(e => e.nScoreTypeID).HasComment("รหัสประเภทคะแนน (TM_data.nDataTypeID = 2)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sScoreTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทคะแนน (TM_data)");
        });

        modelBuilder.Entity<TB_Area_ScoreBefore_History>(entity =>
        {
            entity.HasKey(e => e.nAreaScoreBeforeID_His);

            entity.Property(e => e.nAreaScoreBeforeID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nAreaScoreBeforeID).HasComment("รหัสหลักตารางคะแนนก่อนการดำเนินงานที่ผูกกับพื้นที่");
            entity.Property(e => e.nProjectScoreBefore)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.nScoreTypeID).HasComment("รหัสประเภทคะแนน (TM_data)");
            entity.Property(e => e.sOther)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.sScoreTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทคะแนน (TM_data)");
        });

        modelBuilder.Entity<TB_Area_Stakeholders>(entity =>
        {
            entity.HasKey(e => e.nAreaStakeholdersID);

            entity.Property(e => e.nAreaStakeholdersID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักของตารางผู้มีส่วนได้ส่วนเสียของพื้นที่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nStakeholdersID).HasComment("รหัสผู้มีส่วนได้ส่วนเสีย (TM_Stakeholders)");
            entity.Property(e => e.sAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.sAffiliation)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("สังกัด");
            entity.Property(e => e.sPhoneNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("หมายเลขโทรศัพท์");
            entity.Property(e => e.sPosition)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ตำแหน่ง");
            entity.Property(e => e.sRemark)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.sStakeholdersName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ชื่อผู้มีส่วนได้ส่วนเสีย (TM_Stakeholders)");
        });

        modelBuilder.Entity<TB_Area_StakeholdersType>(entity =>
        {
            entity.HasKey(e => new { e.nStakeholdersTypeID, e.nAreaStakeholdersTypeID }).HasName("PK_TB_Area_StakeholdersType_1");

            entity.Property(e => e.nStakeholdersTypeID).HasComment("รหัสประเภทผู้มีส่วนได้ส่วนเสีย (รหัสจาก TM_Data)");
            entity.Property(e => e.nAreaStakeholdersTypeID).HasComment("รหัสตารางผู้มีส่วนได้ส่วนเสียที่อยู่ในพื้นที่ (TB_Area_Stakeholders)");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sStakeholdersTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทผู้มีส่วนได้ส่วนเสีย (รหัสจาก TM_Data)");
        });

        modelBuilder.Entity<TB_Area_StakeholdersType_History>(entity =>
        {
            entity.HasKey(e => e.nAreaStakeholdersTypeID_His).HasName("PK_TB_Area_StakeholdersType_History_1");

            entity.Property(e => e.nAreaStakeholdersTypeID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaStakeholdersTypeID).HasComment("รหัสตารางผู้มีส่วนได้ส่วนเสียที่อยู่ในพื้นที่ (TB_Area_Stakeholders)");
            entity.Property(e => e.nStakeholdersTypeID).HasComment("รหัสประเภทผู้มีส่วนได้ส่วนเสีย (รหัสจาก TM_Data)");
            entity.Property(e => e.sStakeholdersTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทผู้มีส่วนได้ส่วนเสีย (รหัสจาก TM_Data)");
        });

        modelBuilder.Entity<TB_Area_Stakeholders_History>(entity =>
        {
            entity.HasKey(e => e.nAreaStakeholdersID_His);

            entity.Property(e => e.nAreaStakeholdersID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAreaID).HasComment("รหัสพื้นที่");
            entity.Property(e => e.nAreaStakeholdersID).HasComment("รหัสหลักของตารางผู้มีส่วนได้ส่วนเสียของพื้นที่");
            entity.Property(e => e.nStakeholdersID).HasComment("รหัสผู้มีส่วนได้ส่วนเสีย (TM_Stakeholders)");
            entity.Property(e => e.sAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.sAffiliation)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("สังกัด");
            entity.Property(e => e.sPhoneNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("หมายเลขโทรศัพท์");
            entity.Property(e => e.sPosition)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ตำแหน่ง");
            entity.Property(e => e.sRemark)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.sStakeholdersName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ชื่อผู้มีส่วนได้ส่วนเสีย (TM_Stakeholders)");
        });

        modelBuilder.Entity<TB_Banner>(entity =>
        {
            entity.HasKey(e => e.nBannerID);

            entity.Property(e => e.nBannerID).ValueGeneratedNever();
            entity.Property(e => e.IsSetDate).HasComment("กำหนดเวลาเริ่มต้น-สิ้นสุดหรือไม่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sBannerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sEndDate).HasColumnType("datetime");
            entity.Property(e => e.sFileName)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.sNote)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.sPath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sStartDate).HasColumnType("datetime");
            entity.Property(e => e.sSystemFileName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_BundleType_Mapping>(entity =>
        {
            entity.HasKey(e => new { e.nBundleType, e.nNatureGrouping }).HasName("PK_TM_BundleType_Mapping");

            entity.Property(e => e.nBundleType).HasComment("รหัสประเภทการรวมกลุ่ม (TM_Master)");
            entity.Property(e => e.nNatureGrouping).HasComment("รหัสลักษณะการรวมกลุ่ม (TM_Master)");
        });

        modelBuilder.Entity<TB_EmailLog>(entity =>
        {
            entity.HasKey(e => e.nLogEmailID).HasName("PK_T_EmailLog");

            entity.Property(e => e.nLogEmailID).ValueGeneratedNever();
            entity.Property(e => e.dLogEmail).HasColumnType("datetime");
            entity.Property(e => e.sBCC)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sCC)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sContent)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.sDebugBCC)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sDebugCC)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sDebugFrom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sDebugTo)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sErrorMsg)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.sFrom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sSubject)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.sTo)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_LogEmail>(entity =>
        {
            entity.HasKey(e => e.nLogEmailID);

            entity.Property(e => e.nLogEmailID).ValueGeneratedNever();
        });

        modelBuilder.Entity<TB_LogLogin>(entity =>
        {
            entity.HasKey(e => e.nLogID);

            entity.Property(e => e.nLogID)
                .ValueGeneratedNever()
                .HasComment("Log ID");
            entity.Property(e => e.dLoginDate)
                .HasComment("Login Date")
                .HasColumnType("datetime");
            entity.Property(e => e.dLogoutDate)
                .HasComment("Logout Date")
                .HasColumnType("datetime");
            entity.Property(e => e.nStatus).HasComment("Status: 1=success, 0=err");
            entity.Property(e => e.sDeviceName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Device Name");
            entity.Property(e => e.sErrorMsg)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("Erroe Message");
            entity.Property(e => e.sIPAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("IP Address");
            entity.Property(e => e.sUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Username");
        });

        modelBuilder.Entity<TB_Project>(entity =>
        {
            entity.HasKey(e => e.nProjectID);

            entity.Property(e => e.nProjectID)
                .ValueGeneratedNever()
                .HasComment("รหัสโครงการ");
            entity.Property(e => e.IsCurrent).HasComment("วันสิ้นสุุดโครงการจนถึงปัจจุบันหรือไม่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dEndDate)
                .HasComment("วันที่สิ้นสุดโครงการ")
                .HasColumnType("date");
            entity.Property(e => e.dStartDate)
                .HasComment("วันที่เริ่มต้นโครงการ")
                .HasColumnType("date");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAgencyID).HasComment("รหัสหน่วยงานที่รับผิดชอบหลัก (รหัสจาก TM_Agency)");
            entity.Property(e => e.nBudgetTypeID).HasComment("ประเภทงบประมาณ (รายพื้นที่/รวมโครงการ)");
            entity.Property(e => e.nCorporateStrategyID).HasComment("รหัส Corporate Strategy (รหัสจาก TM_Data)");
            entity.Property(e => e.nEndYear).HasComment("เก็บปีที่สิ้นสุด กรณีเป็นโครงการเก่า ที่ไม่มีวันที่");
            entity.Property(e => e.nProjectNatureID).HasComment("รหัสลักษณะโครงการ (รหัสจาก TM_Data)");
            entity.Property(e => e.nSDGsID).HasComment("Global Strategies หลัก (รหัสจาก TM_Data)");
            entity.Property(e => e.nStartYear).HasComment("เก็บปีที่เริ่มต้น กรณีเป็นโครงการเก่า ที่ไม่มีวันที่");
            entity.Property(e => e.nStatus).HasComment("True =  โครงการ  Activate, False= ปิดโครงการ");
            entity.Property(e => e.nUpdateTypeID).HasComment("ประเภทการ Update Progress");
            entity.Property(e => e.sAgencyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงานที่รับผิดชอบหลัก (จาก TM_Agency)");
            entity.Property(e => e.sBudgetTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sBusinessConnection)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("ความเชื่อมโยงกับธุรกิจ");
            entity.Property(e => e.sCorporateStrategyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sObjective)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("วัตถุประสงค์");
            entity.Property(e => e.sOtherNature)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sProjectName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ชื่อโครงการ");
            entity.Property(e => e.sProjectNatureName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อลักษณะโครงการ (รหัสจาก TM_Data)");
            entity.Property(e => e.sProjectOrigin)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("ที่มาโครงการ");
            entity.Property(e => e.sRisk)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("ความเสี่ยง");
            entity.Property(e => e.sSDGsDescription)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.sSDGsName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อ Global Strategies หลัก (รหัสจาก TM_Data)");
            entity.Property(e => e.sSDGsSecondaryDescription)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.sTarget)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("เป้าหมาย");
            entity.Property(e => e.sUpdateTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_AgencyCooperation>(entity =>
        {
            entity.HasKey(e => e.nProjectAgencyCooperationID);

            entity.Property(e => e.nProjectAgencyCooperationID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางหน่วยงานที่ให้ความร่วมมือโครงการ");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAgencyCooperationID).HasComment("รหัสหน่วยงานที่ให้ความร่วมมือ (TM_Data)");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.sAgencyCooperationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงานที่ให้ความร่วมมือ (TM_Data)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_AgencyCooperation_History>(entity =>
        {
            entity.HasKey(e => e.nProjectAgencyCooperationID_His);

            entity.Property(e => e.nProjectAgencyCooperationID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAgencyCooperationID).HasComment("รหัสหน่วยงานที่ให้ความร่วมมือ (TM_Data)");
            entity.Property(e => e.nProjectAgencyCooperationID).HasComment("รหัสหลักตารางหน่วยงานที่ให้ความร่วมมือโครงการ");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.sAgencyCooperationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงานที่ให้ความร่วมมือ (TM_Data)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_AgencySecondary>(entity =>
        {
            entity.HasKey(e => e.nProjectAgencySecondaryID).HasName("PK_TB_AgencySecondary");

            entity.Property(e => e.nProjectAgencySecondaryID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางหน่วยงานที่รับผิดชอบรอง");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAgencyID).HasComment("รหัสหน่วยงานที่รับผิดชอบ (เอารหัสจาก TM_Agency)");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.sAgencyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงานที่รับผิดชอบ (TM_Agency)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_AgencySecondary_History>(entity =>
        {
            entity.HasKey(e => e.nProjectAgencySecondaryID_His).HasName("PK_TB_AgencySecondary_History");

            entity.Property(e => e.nProjectAgencySecondaryID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAgencyID).HasComment("รหัสหน่วยงานที่รับผิดชอบ (เอารหัสจากTM_Agency)");
            entity.Property(e => e.nProjectAgencySecondaryID).HasComment("รหัสหลักตารางหน่วยงานที่รับผิดชอบรอง");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.sAgencyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงานที่รับผิดชอบ (TM_Agency)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_Budget>(entity =>
        {
            entity.HasKey(e => e.nProjectBudgetID);

            entity.Property(e => e.nProjectBudgetID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางงบประมาณตั้งต้นโครงการ");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nProjectBudget)
                .HasComment("งบประมาณตั้งต้นของโครงการแต่ละปี")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_Budget_History>(entity =>
        {
            entity.HasKey(e => e.nProjectBudgetID_His).HasName("PK_TB_Project_Bidget_History");

            entity.Property(e => e.nProjectBudgetID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nProjectBudget)
                .HasComment("งบประมาณตั้งต้นของโครงการแต่ละปี")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.nProjectBudgetID).HasComment("รหัสหลักตารางงบประมาณตั้งต้นโครงการ");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_File>(entity =>
        {
            entity.HasKey(e => e.nProjectFileID).HasName("PK_TB_File");

            entity.Property(e => e.nProjectFileID).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sFilename)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.sPath)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.sSystemFilename)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_History>(entity =>
        {
            entity.HasKey(e => e.nProjectID_His);

            entity.Property(e => e.nProjectID_His).ValueGeneratedNever();
            entity.Property(e => e.IsCurrent).HasComment("วันสิ้นสุุดโครงการจนถึงปัจจุบันหรือไม่");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dEndDate)
                .HasComment("วันที่สิ้นสุดโครงการ")
                .HasColumnType("date");
            entity.Property(e => e.dStartDate)
                .HasComment("วันที่เริ่มต้นโครงการ")
                .HasColumnType("date");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAgencyID).HasComment("รหัสหน่วยงานที่รับผิดชอบหลัก (รหัสจาก TM_Agency)");
            entity.Property(e => e.nBudgetTypeID).HasComment("ประเภทงบประมาณ (รายพื้นที่/รวมโครงการ)");
            entity.Property(e => e.nCorporateStrategyID).HasComment("รหัส Corporate Strategy (รหัสจาก TM_Data)");
            entity.Property(e => e.nEndYear).HasComment("เก็บปีที่สิ้นสุด กรณีเป็นโครงการเก่า ที่ไม่มีวันที่");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.nProjectNatureID).HasComment("รหัสลักษณะโครงการ (รหัสจาก TM_Data)");
            entity.Property(e => e.nSDGsID).HasComment("Global Strategies หลัก (รหัสจาก TM_Data)");
            entity.Property(e => e.nStartYear).HasComment("เก็บปีที่เริ่มต้น กรณีเป็นโครงการเก่า ที่ไม่มีวันที่");
            entity.Property(e => e.nUpdateTypeID).HasComment("ประเภทการ Update Progress");
            entity.Property(e => e.sAgencyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงานที่รับผิดชอบหลัก ( TM_Agency)");
            entity.Property(e => e.sBudgetTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sBusinessConnection)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("ความเชื่อมโยงกับธุรกิจ");
            entity.Property(e => e.sCorporateStrategyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sObjective)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("วัตถุประสงค์");
            entity.Property(e => e.sOtherNature)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sProjectName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("ชื่อโครงการ");
            entity.Property(e => e.sProjectNatureName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อลักษณะโครงการ (รหัสจาก TM_Data)");
            entity.Property(e => e.sProjectOrigin)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("ที่มาโครงการ");
            entity.Property(e => e.sRisk)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("ความเสี่ยง");
            entity.Property(e => e.sSDGsDescription)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.sSDGsName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อ Global Strategies หลัก (รหัสจาก TM_Data)");
            entity.Property(e => e.sSDGsSecondaryDescription)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.sTarget)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("เป้าหมาย");
            entity.Property(e => e.sUpdateTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_Indicator>(entity =>
        {
            entity.HasKey(e => e.nProjectIndicatorID);

            entity.Property(e => e.nProjectIndicatorID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักของตารางตัวชี้วัดที่ผูกกับโครงการ");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nIndicatorID).HasComment("รหัสตัวชี้วัด (รหัส TM_Indicator)");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.sIndicatorName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อตัวชี้วัด");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_Indicator_History>(entity =>
        {
            entity.HasKey(e => e.nProjectIndicatorID_His);

            entity.Property(e => e.nProjectIndicatorID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nIndicatorID).HasComment("รหัสตัวชี้วัด (รหัส TM_Indicator)");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.nProjectIndicatorID).HasComment("รหัสหลักของตารางตัวชี้วัดที่ผูกกับโครงการ");
            entity.Property(e => e.sIndicatorName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อตัวชี้วัด");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_ResultBudget>(entity =>
        {
            entity.HasKey(e => e.nProjectResultBudgetID);

            entity.Property(e => e.nProjectResultBudgetID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางข้อมูลงบประมาณที่ใช้จริง (กรณีงบประมาณ เป็นประเภท รวมโครงการ)");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAroundUpdate).HasComment("รอบที่อัพเดต");
            entity.Property(e => e.nResultBudget).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.nYear).HasComment("ปี");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_ResultBudget_History>(entity =>
        {
            entity.HasKey(e => e.nProjectResultBudgetID_His);

            entity.Property(e => e.nProjectResultBudgetID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAroundUpdate).HasComment("รอบที่อัพเดต");
            entity.Property(e => e.nProjectResultBudgetID).HasComment("รหัสหลักตารางข้อมูลงบประมาณที่ใช้จริง (กรณีงบประมาณ เป็นประเภท รวมโครงการ)");
            entity.Property(e => e.nResultBudget).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.nYear).HasComment("ปี");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_ResultIndicator>(entity =>
        {
            entity.HasKey(e => e.nProjectResultIndicatorID);

            entity.Property(e => e.nProjectResultIndicatorID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางผลลัพธ์ตัวชี้วัดที่ผูกกับโครงการ");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAroundUpdate).HasComment("รอบการอัพเดต");
            entity.Property(e => e.nIndicatorID).HasComment("รหัสตัวชี้วัด (TM_Stakeholders)");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.sDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sIndicatorName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_ResultIndicator_History>(entity =>
        {
            entity.HasKey(e => e.nProjectResultIndicatorID_His);

            entity.Property(e => e.nProjectResultIndicatorID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAroundUpdate).HasComment("รอบการอัพเดต");
            entity.Property(e => e.nIndicatorID).HasComment("รหัสตัวชี้วัด (TM_Stakeholders)");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.nProjectResultIndicatorID).HasComment("รหัสหลักตารางผลลัพธ์ตัวชี้วัดที่ผูกกับโครงการ");
            entity.Property(e => e.sDescroption)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sIndicatorName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Project_ResultScore>(entity =>
        {
            entity.HasKey(e => e.nProjectResultScoreID);

            entity.Property(e => e.nProjectResultScoreID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางคะแนนหลังดำเนินการ กรณีที่ Update Progress ที่โครงการ");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAroundUpdate).HasComment("รอบการอัพเดต");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.nResultScore).HasComment("คะแนนหลังดำเนินการ");
            entity.Property(e => e.nScoreTypeID).HasComment("รหัสประเภทคะแนน (TM_data.nDataTypeID = 2) ");
            entity.Property(e => e.nYear).HasComment("ปี");
            entity.Property(e => e.sDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sScoreTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทคะแนน (TM_Data)");
        });

        modelBuilder.Entity<TB_Project_ResultScore_History>(entity =>
        {
            entity.HasKey(e => e.nProjectResultScoreID_His);

            entity.Property(e => e.nProjectResultScoreID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAroundUpdate).HasComment("รอบการอัพเดต");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.nProjectResultScoreID).HasComment("รหัสหลักตารางคะแนนหลังดำเนินการ กรณีที่ Update Progress ที่โครงการ");
            entity.Property(e => e.nResultScore).HasComment("คะแนนหลังดำเนินการ");
            entity.Property(e => e.nScoreTypeID).HasComment("รหัสประเภทคะแนน (TM_Data)");
            entity.Property(e => e.nYear).HasComment("ปี");
            entity.Property(e => e.sDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sScoreTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทคะแนน (TM_Data)");
        });

        modelBuilder.Entity<TB_Project_SDGsSecondary>(entity =>
        {
            entity.HasKey(e => e.nProjectSDGsSecondaryID).HasName("PK_TB_Project_SDG_Secondary");

            entity.Property(e => e.nProjectSDGsSecondaryID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักของตาราง SDG รองของโครงการ");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.nSDGsSecondaryID).HasComment("รหัส SDG (รหัสจาก TM_SDGs)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sSDGsSecondaryName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อ SDG (รหัสจาก TM_SDGs)");
        });

        modelBuilder.Entity<TB_Project_SDGsSecondary_History>(entity =>
        {
            entity.HasKey(e => e.nProjectSDGsSecondaryID_His);

            entity.Property(e => e.nProjectSDGsSecondaryID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.nProjectSDGsSecondaryID).HasComment("รหัสหลักของตาราง SDG รองของโครงการ");
            entity.Property(e => e.nSDGsSecondaryID).HasComment("รหัส SDG (รหัสจาก TM_SDGs)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sSDGsSecondaryName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อ SDG (รหัสจาก TM_SDGs)");
        });

        modelBuilder.Entity<TB_Project_ScoreBefore>(entity =>
        {
            entity.HasKey(e => e.nProjectScoreBeforeID);

            entity.Property(e => e.nProjectScoreBeforeID)
                .ValueGeneratedNever()
                .HasComment("รหัสหลักตารางคะแนนก่อนการดำเนินงานที่ผูกกับโครงการ");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.nProjectScoreBefore).HasComment("คะแนนก่อนดำเนินการ");
            entity.Property(e => e.nScoreTypeID).HasComment("รหัสประเภทคะแนน (TM_data.nDataTypeID = 2)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sScoreTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทคะแนน (TM_data)");
        });

        modelBuilder.Entity<TB_Project_ScoreBefore_History>(entity =>
        {
            entity.HasKey(e => e.nProjectScoreBeforeID_His);

            entity.Property(e => e.nProjectScoreBeforeID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nProjectID).HasComment("รหัสโครงการ");
            entity.Property(e => e.nProjectScoreBefore).HasComment("คะแนนก่อนดำเนินการ");
            entity.Property(e => e.nProjectScoreBeforeID).HasComment("รหัสหลักตารางคะแนนก่อนการดำเนินงานที่ผูกกับโครงการ");
            entity.Property(e => e.nScoreTypeID).HasComment("รหัสประเภทคะแนน (TM_data)");
            entity.Property(e => e.sOther)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sScoreTypeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อประเภทคะแนน (TM_data)");
        });

        modelBuilder.Entity<TB_Request>(entity =>
        {
            entity.HasKey(e => e.nRequestID);

            entity.Property(e => e.nRequestID).ValueGeneratedNever();
            entity.Property(e => e.IsSendEmail_AE).HasComment("รหัสผู้ช่วย กสญ. ที่ต้องส่งอีเมลเมื่อ WorkFlow Approve Success");
            entity.Property(e => e.IsSendEmail_DV).HasComment("รหัสผู้จัดการส่วน กสญ. ที่ต้องส่งอีเมลเมื่อ WorkFlow Approve Success");
            entity.Property(e => e.IsSendEmail_VP).HasComment("รหัสผู้จัดการฝ่าย กสญ. ที่ต้องส่งอีเมลเมื่อ WorkFlow Approve Success");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nRequestTypesID).HasComment("รหัสประเภทคำขอ (TM_RequestType)");
            entity.Property(e => e.sComment)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Request_History>(entity =>
        {
            entity.HasKey(e => e.nRequestID_His);

            entity.Property(e => e.nRequestID_His).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nRequestTypesID).HasComment("รหัสประเภทคำขอ (TM_RequestType)");
            entity.Property(e => e.nSendEmail_AE_ID).HasComment("รหัสผู้ช่วย กสญ. ที่ต้องส่งอีเมลเมื่อ WorkFlow Approve Success");
            entity.Property(e => e.nSendEmail_DV_ID).HasComment("รหัสผู้จัดการส่วน กสญ. ที่ต้องส่งอีเมลเมื่อ WorkFlow Approve Success");
            entity.Property(e => e.nSendEmail_VP_ID).HasComment("รหัสผู้จัดการฝ่าย กสญ. ที่ต้องส่งอีเมลเมื่อ WorkFlow Approve Success");
            entity.Property(e => e.sComment)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Schedule>(entity =>
        {
            entity.HasKey(e => e.nScheduleID);

            entity.Property(e => e.nScheduleID).ValueGeneratedNever();
            entity.Property(e => e.dLogEnd).HasColumnType("datetime");
            entity.Property(e => e.dLogStart).HasColumnType("datetime");
            entity.Property(e => e.sDetail)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sErrorMessage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sStackTrace)
                .HasMaxLength(3000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TB_Setup_UpdateProgress>(entity =>
        {
            entity.HasKey(e => e.nUpdateProgressID).HasName("PK_TB_Update_Progress");

            entity.Property(e => e.nUpdateProgressID).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dEndDate).HasColumnType("date");
            entity.Property(e => e.dStartDate).HasColumnType("date");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nRound).HasComment("รอบที่");
        });

        modelBuilder.Entity<TB_User>(entity =>
        {
            entity.HasKey(e => e.nUserID);

            entity.Property(e => e.nUserID).ValueGeneratedNever();
            entity.Property(e => e.dChangePasswordDate).HasColumnType("datetime");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nAgencyID).HasComment("หน่วยงานที่สังกัด");
            entity.Property(e => e.nDepartment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("แผนก");
            entity.Property(e => e.nEmployeeID).HasComment("รหัสพนักงาน");
            entity.Property(e => e.nUserTypeID).HasComment("รหัสประเภทผู้ใช้งาน (TM_DataType.DataTypeID = 1)");
            entity.Property(e => e.sEmail).HasMaxLength(100);
            entity.Property(e => e.sName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ตำแหน่ง");
            entity.Property(e => e.sPassword).HasMaxLength(20);
            entity.Property(e => e.sPhoneNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sPosition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ตำแหน่ง");
            entity.Property(e => e.sSureName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.sUsername).HasMaxLength(100);
        });

        modelBuilder.Entity<TM_Agency>(entity =>
        {
            entity.HasKey(e => e.AgencyID);

            entity.Property(e => e.AgencyID)
                .ValueGeneratedNever()
                .HasComment("รหัสหน่วยงาน");
            entity.Property(e => e.AgencyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อหน่วยงาน");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sUnitCode)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_Config>(entity =>
        {
            entity.HasKey(e => e.nConfig_ID);

            entity.Property(e => e.nConfig_ID).ValueGeneratedNever();
            entity.Property(e => e.IsConfig_Bit).HasComment("ข้อมูลที่ต้องการ Config สำหรับข้อมูลที่เป็นประเภท Bit");
            entity.Property(e => e.dConfig_Datetime)
                .HasComment("ข้อมูลที่ต้องการ Config สำหรับข้อมูลที่เป็นประเภท Datetime")
                .HasColumnType("datetime");
            entity.Property(e => e.nConfig_Int).HasComment("ข้อมูลที่ต้องการ Config สำหรับข้อมูลที่เป็นประเภท Int");
            entity.Property(e => e.sConfig_Description)
                .IsUnicode(false)
                .HasComment("คำอธิบายของ Config");
            entity.Property(e => e.sConfig_Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อ ของ Config");
            entity.Property(e => e.sConfig_Varchar)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("ข้อมูลที่ต้องการ Config สำหรับข้อมูลที่เป็นประเภท Varchar");
        });

        modelBuilder.Entity<TM_ConfigFlow>(entity =>
        {
            entity.HasKey(e => new { e.sRequestType, e.nGroupID });

            entity.Property(e => e.sApprove)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sCancel)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sDelegate)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sHR)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sInputMode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sNeedInfo)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sPostToSAP)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sReject)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sRework)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.sSubmit)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_Data>(entity =>
        {
            entity.HasKey(e => e.nDataID).HasName("PK_TM_Data_1");

            entity.Property(e => e.nDataID).ValueGeneratedNever();
            entity.Property(e => e.dCraeteDate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sAbbr)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.sDescription)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.sNameEN)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.sNameTH)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_DataType>(entity =>
        {
            entity.HasKey(e => e.nDataTypeID).HasName("PK_TM_Data");

            entity.Property(e => e.nDataTypeID)
                .ValueGeneratedNever()
                .HasComment("รหัสหประเภทข้อมูล");
            entity.Property(e => e.dCraeteDate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sDescription)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("รายละเอียดข้อมูล");
            entity.Property(e => e.sNameEN)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.sNameTH)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("ชื่อข้อมูล");
        });

        modelBuilder.Entity<TM_DisplayAdminMenu>(entity =>
        {
            entity.HasKey(e => e.DisplayAdminMenuID);

            entity.Property(e => e.DisplayAdminMenuID)
                .ValueGeneratedNever()
                .HasComment("รหัส Master Data");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nQuantity).HasComment("จำนวน");
        });

        modelBuilder.Entity<TM_District>(entity =>
        {
            entity.HasKey(e => e.nDistrictID).HasName("PK__TM_Distr__E1F3F87F1C81C24C");

            entity.Property(e => e.nDistrictID).ValueGeneratedNever();
            entity.Property(e => e.sDistrictNameEN)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sDistrictNameTH)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_Indicator>(entity =>
        {
            entity.HasKey(e => e.nIndicatorID);

            entity.Property(e => e.nIndicatorID)
                .ValueGeneratedNever()
                .HasComment("รหัสตัวชี้วัด");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("หน่วยตัวชี้วัด");
            entity.Property(e => e.sDrescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sIndicatorName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อตัวชี้วัด");
        });

        modelBuilder.Entity<TM_LoginType>(entity =>
        {
            entity.HasKey(e => e.nLoginTypeID);

            entity.Property(e => e.nLoginTypeID)
                .ValueGeneratedNever()
                .HasComment("Login Type ID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("1 = Active, 0 = Inactive");
            entity.Property(e => e.sLoginTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Login Type Name");
            entity.Property(e => e.sUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Url");
        });

        modelBuilder.Entity<TM_Menu>(entity =>
        {
            entity.HasKey(e => e.nMenuID);

            entity.Property(e => e.nMenuID).ValueGeneratedNever();
            entity.Property(e => e.nMenuOrder).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.sIcon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.sMenuName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.sRoute)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_Occupation>(entity =>
        {
            entity.HasKey(e => e.nOccupationID);

            entity.Property(e => e.nOccupationID)
                .ValueGeneratedNever()
                .HasComment("รหัสอาชีพ");
            entity.Property(e => e.dCraeteDate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.sOccupationName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_Provinces>(entity =>
        {
            entity.HasKey(e => e.nProvinceID).HasName("PK__TM_Provi__B634BC04584C7ED1");

            entity.Property(e => e.nProvinceID).ValueGeneratedNever();
            entity.Property(e => e.nGeographyID).HasDefaultValueSql("((0))");
            entity.Property(e => e.sProvinceNameEN)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.sProvinceNameTH)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.sProvinceShort)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<TM_RequestType>(entity =>
        {
            entity.HasKey(e => e.nRequestTypeID);

            entity.Property(e => e.nRequestTypeID).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sRequestTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_SDGs>(entity =>
        {
            entity.HasKey(e => e.nSDGsID);

            entity.Property(e => e.nSDGsID)
                .ValueGeneratedNever()
                .HasComment("รหัส SDGs");
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nSDGsName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sDrescription)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.sFileName)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.sPath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.sSystemFileName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_Stakeholders>(entity =>
        {
            entity.HasKey(e => e.nStakeholdersID);

            entity.Property(e => e.nStakeholdersID).ValueGeneratedNever();
            entity.Property(e => e.dCreate).HasColumnType("datetime");
            entity.Property(e => e.dDelete).HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.sStakeholdersName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("รหัสพื้นที่");
        });

        modelBuilder.Entity<TM_Status>(entity =>
        {
            entity.HasKey(e => new { e.nStatusID, e.nRequestTypeID });

            entity.Property(e => e.sDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.sNextStatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.sStatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_Subdistrict>(entity =>
        {
            entity.HasKey(e => e.sSubDistrictID).HasName("PK__TM_Subdi__8A7A68B62EB1F2A5");

            entity.Property(e => e.sSubDistrictID)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.sSubdistrictNameEN)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sSubdistrictNameTH)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_UserGroup>(entity =>
        {
            entity.HasKey(e => new { e.nUserGroupID, e.nUserRoleID });

            entity.Property(e => e.nUserGroupID).ValueGeneratedOnAdd();
            entity.Property(e => e.nUserRoleID).HasComment("Refer. TM_UserRole");
            entity.Property(e => e.IsDelete).HasComment("true = ลบ , false = ยังไม่ถูกลบ");
            entity.Property(e => e.dCreate)
                .HasComment("วันที่สร้างรายการ")
                .HasColumnType("datetime");
            entity.Property(e => e.dDelete)
                .HasComment("วันที่ลบรายการ")
                .HasColumnType("datetime");
            entity.Property(e => e.dUpdate).HasColumnType("datetime");
            entity.Property(e => e.nDeleteBy).HasComment("ผู้ที่ลบรายการ");
            entity.Property(e => e.sUserGroupDescription)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.sUserGroupName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_UserGroupPermisson>(entity =>
        {
            entity.HasKey(e => new { e.nUserGroupID, e.nMenuID });

            entity.Property(e => e.nMenuID).HasComment("Refer.TM_Menu");
            entity.Property(e => e.nPermission).HasComment("Permission 2=Full Control, 1=Read Only, 0=Disable");
        });

        modelBuilder.Entity<TM_UserLoginType>(entity =>
        {
            entity.HasKey(e => e.nUserLoginTypeID).HasName("PK_TM_UserLogin");

            entity.Property(e => e.nUserLoginTypeID)
                .ValueGeneratedNever()
                .HasComment("User Login Type ID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("1 = Active, 0 = Inactive");
            entity.Property(e => e.nOrder).HasComment("Sort Order");
            entity.Property(e => e.sUserLoginName)
                .HasMaxLength(50)
                .HasComment("User Login Name");
        });

        modelBuilder.Entity<TM_UserMappingGroup>(entity =>
        {
            entity.HasKey(e => new { e.nEmployeeID, e.nUserGroupID });

            entity.Property(e => e.nUserGroupID).HasComment("Refer.TM_UserGroup");
        });

        modelBuilder.Entity<TM_UserMappingRole>(entity =>
        {
            entity.HasKey(e => new { e.nEmployeeID, e.nUserRoleID });

            entity.Property(e => e.nEmployeeID).HasComment("Refer.TB_Employee");
            entity.Property(e => e.nUserRoleID).HasComment("Refer.TM_UserRole");
        });

        modelBuilder.Entity<TM_UserPermission>(entity =>
        {
            entity.HasKey(e => new { e.nEmployeeID, e.nMenuID });

            entity.Property(e => e.nEmployeeID).HasComment("Refer.TB_Employee");
            entity.Property(e => e.nMenuID).HasComment("Refer.TM_Menu");
            entity.Property(e => e.nPermission).HasComment("Permission 2=Full Control, 1=Read Only, 0=Disable");
        });

        modelBuilder.Entity<TM_UserRole>(entity =>
        {
            entity.HasKey(e => e.nUserRoleID);

            entity.Property(e => e.nUserRoleID).ValueGeneratedNever();
            entity.Property(e => e.IsDelete).HasComment("true = ลบ , false = ยังไม่ถูกลบ");
            entity.Property(e => e.dCreate)
                .HasComment("วันที่สร้างรายการ")
                .HasColumnType("datetime");
            entity.Property(e => e.dDelete)
                .HasComment("วันที่ลบรายการ")
                .HasColumnType("datetime");
            entity.Property(e => e.dUpdate)
                .HasComment("วันที่แก้ไขรายการ")
                .HasColumnType("datetime");
            entity.Property(e => e.nCreateBy).HasComment("ผู้สร้างรายการ");
            entity.Property(e => e.nDeleteBy).HasComment("ผู้ที่ลบรายการ");
            entity.Property(e => e.nUpdateBy).HasComment("ผู้แก้ไขรายการ");
            entity.Property(e => e.sUserRoleDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.sUserRoleName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TM_UserRolePermission>(entity =>
        {
            entity.HasKey(e => new { e.nUserRoleID, e.nMenuID });

            entity.Property(e => e.nUserRoleID).HasComment("Refer.TM_UserRole");
            entity.Property(e => e.nMenuID).HasComment("Refer.TM_Menu");
            entity.Property(e => e.nPermission).HasComment("Permission 2=Full Control, 1=Read Only, 0=Disable");
        });

        modelBuilder.Entity<TM_UserType>(entity =>
        {
            entity.HasKey(e => e.nUserTypeID);

            entity.Property(e => e.nUserTypeID)
                .ValueGeneratedNever()
                .HasComment("User Type ID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("1 = Active, 0 = Inactive");
            entity.Property(e => e.nOrder).HasComment("Sort Order");
            entity.Property(e => e.sUserTypeName)
                .HasMaxLength(50)
                .HasComment("User Type Name");
        });

        modelBuilder.Entity<TM_UserTypeMappingLogin>(entity =>
        {
            entity.HasKey(e => new { e.nUserTypeID, e.nUserLoginTypeID });

            entity.Property(e => e.nUserTypeID).HasComment("Refer.TM_UserType");
            entity.Property(e => e.nUserLoginTypeID).HasComment("Refer.TM_UserLoginType");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
