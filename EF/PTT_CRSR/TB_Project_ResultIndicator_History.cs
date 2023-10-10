using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Project_ResultIndicator_History
{
    public int nProjectResultIndicatorID_His { get; set; }

    /// <summary>
    /// รหัสหลักตารางผลลัพธ์ตัวชี้วัดที่ผูกกับโครงการ
    /// </summary>
    public int nProjectResultIndicatorID { get; set; }

    /// <summary>
    /// รหัสโครงการ
    /// </summary>
    public int nProjectID { get; set; }

    /// <summary>
    /// รอบการอัพเดต
    /// </summary>
    public int nAroundUpdate { get; set; }

    public int nYear { get; set; }

    /// <summary>
    /// รหัสตัวชี้วัด (TM_Stakeholders)
    /// </summary>
    public int nIndicatorID { get; set; }

    public string? sIndicatorName { get; set; }

    public int? nResultIndecator { get; set; }

    public string? sDescroption { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
