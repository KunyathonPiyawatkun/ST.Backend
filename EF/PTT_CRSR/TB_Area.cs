using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area
{
    public int AreaID { get; set; }

    public int ProjectID { get; set; }

    public int nOrder { get; set; }

    /// <summary>
    /// True =  พื้นที่  Activate, False= ปิดพื้นที่
    /// </summary>
    public bool nStatus { get; set; }

    /// <summary>
    /// ยังไม่ใช้ฟิลด์นี้ ทำเผื่อไว้
    /// </summary>
    public DateTime? dStartDate { get; set; }

    /// <summary>
    /// ยังไม่ใช้ฟิลด์นี้ ทำเผื่อไว้
    /// </summary>
    public DateTime? dEndDate { get; set; }

    /// <summary>
    /// ประเภทพื้นที่
    /// </summary>
    public int nAreaTypeID { get; set; }

    /// <summary>
    /// ชื่อประเภทพื้นที่ (TM_Data)
    /// </summary>
    public string? sAreaTypeName { get; set; }

    public string? nAreaName { get; set; }

    /// <summary>
    /// รหัสจังหวัด
    /// </summary>
    public int nProvinceID { get; set; }

    public string? sProvinceNameTH { get; set; }

    /// <summary>
    /// รหัสอำเภอ
    /// </summary>
    public int nDistrictID { get; set; }

    public string? sDistrictNameTH { get; set; }

    /// <summary>
    /// รหัสตำบล
    /// </summary>
    public string sSubDistrictID { get; set; } = null!;

    public string? sSubdistrictNameTH { get; set; }

    public string? nLatitude { get; set; }

    public string? nLongitude { get; set; }

    public string? sPathMap { get; set; }

    /// <summary>
    /// ความร่วมมือหน่วยงาน/องค์กรอื่น ๆ
    /// </summary>
    public string? sCooperation { get; set; }

    /// <summary>
    /// ความเชื่อมโยงกับ ปตท.
    /// </summary>
    public string? sConnection { get; set; }

    /// <summary>
    /// คำอธิบายเพิ่มเติมประเภทชุมชน
    /// </summary>
    public string? sExplainMore { get; set; }

    /// <summary>
    /// จำนวนประชากร
    /// </summary>
    public int? nPopulation { get; set; }

    /// <summary>
    /// จำนวนครัวเรือน
    /// </summary>
    public int? nHousehold { get; set; }

    /// <summary>
    /// รายได้เฉลี่ย
    /// </summary>
    public int? nAverageIncome { get; set; }

    /// <summary>
    /// การท่องเที่ยว
    /// </summary>
    public string sTravel { get; set; } = null!;

    /// <summary>
    /// วัฒนธรรม
    /// </summary>
    public string? sCulture { get; set; }

    /// <summary>
    /// ความคิดเห็น ความคาดหวัง ข้อกังวลของชุมชน
    /// </summary>
    public string? sComment { get; set; }

    public string? sRisk { get; set; }

    /// <summary>
    /// หน่วยงานอื่น ๆ ที่ทับซ้อนกันในพื้นที่
    /// </summary>
    public string? sAnotherAgency { get; set; }

    /// <summary>
    /// รายละเอียดประเภทการรวมกลุ่มแบบทางการ
    /// </summary>
    public string? sBundleTypeFormal { get; set; }

    /// <summary>
    /// รายละเอียดประเภทการรวมกลุ่มแบบไม่ทางการ
    /// </summary>
    public string? sBundleTypeInformal { get; set; }

    public bool IsActive { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }

    public bool IsFormal { get; set; }

    public bool IsInFormal { get; set; }
}
