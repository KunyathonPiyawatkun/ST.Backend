using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Project
{
    /// <summary>
    /// รหัสโครงการ
    /// </summary>
    public int nProjectID { get; set; }

    /// <summary>
    /// ชื่อโครงการ
    /// </summary>
    public string sProjectName { get; set; } = null!;

    /// <summary>
    /// True =  โครงการ  Activate, False= ปิดโครงการ
    /// </summary>
    public bool nStatus { get; set; }

    public int nOrder { get; set; }

    /// <summary>
    /// รหัสลักษณะโครงการ (รหัสจาก TM_Data)
    /// </summary>
    public int nProjectNatureID { get; set; }

    /// <summary>
    /// ชื่อลักษณะโครงการ (รหัสจาก TM_Data)
    /// </summary>
    public string? sProjectNatureName { get; set; }

    public string? sOtherNature { get; set; }

    /// <summary>
    /// รหัสหน่วยงานที่รับผิดชอบหลัก (รหัสจาก TM_Agency)
    /// </summary>
    public int nAgencyID { get; set; }

    /// <summary>
    /// ชื่อหน่วยงานที่รับผิดชอบหลัก (จาก TM_Agency)
    /// </summary>
    public string? sAgencyName { get; set; }

    public bool IsMigrate { get; set; }

    /// <summary>
    /// วันที่เริ่มต้นโครงการ
    /// </summary>
    public DateTime? dStartDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุดโครงการ
    /// </summary>
    public DateTime? dEndDate { get; set; }

    /// <summary>
    /// เก็บปีที่เริ่มต้น กรณีเป็นโครงการเก่า ที่ไม่มีวันที่
    /// </summary>
    public int? nStartYear { get; set; }

    /// <summary>
    /// เก็บปีที่สิ้นสุด กรณีเป็นโครงการเก่า ที่ไม่มีวันที่
    /// </summary>
    public int? nEndYear { get; set; }

    /// <summary>
    /// วันสิ้นสุุดโครงการจนถึงปัจจุบันหรือไม่
    /// </summary>
    public bool IsCurrent { get; set; }

    /// <summary>
    /// Global Strategies หลัก (รหัสจาก TM_Data)
    /// </summary>
    public int nSDGsID { get; set; }

    /// <summary>
    /// ชื่อ Global Strategies หลัก (รหัสจาก TM_Data)
    /// </summary>
    public string? sSDGsName { get; set; }

    public string? sSDGsDescription { get; set; }

    public string? sSDGsSecondaryDescription { get; set; }

    /// <summary>
    /// รหัส Corporate Strategy (รหัสจาก TM_Data)
    /// </summary>
    public int nCorporateStrategyID { get; set; }

    public string? sCorporateStrategyName { get; set; }

    /// <summary>
    /// ที่มาโครงการ
    /// </summary>
    public string sProjectOrigin { get; set; } = null!;

    /// <summary>
    /// วัตถุประสงค์
    /// </summary>
    public string sObjective { get; set; } = null!;

    /// <summary>
    /// ความเชื่อมโยงกับธุรกิจ
    /// </summary>
    public string sBusinessConnection { get; set; } = null!;

    /// <summary>
    /// เป้าหมาย
    /// </summary>
    public string sTarget { get; set; } = null!;

    /// <summary>
    /// ความเสี่ยง
    /// </summary>
    public string sRisk { get; set; } = null!;

    /// <summary>
    /// ประเภทงบประมาณ (รายพื้นที่/รวมโครงการ)
    /// </summary>
    public int nBudgetTypeID { get; set; }

    public string? sBudgetTypeName { get; set; }

    /// <summary>
    /// ประเภทการ Update Progress
    /// </summary>
    public int nUpdateTypeID { get; set; }

    public string? sUpdateTypeName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
