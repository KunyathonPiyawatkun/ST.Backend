using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Project_Indicator
{
    /// <summary>
    /// รหัสหลักของตารางตัวชี้วัดที่ผูกกับโครงการ
    /// </summary>
    public int nProjectIndicatorID { get; set; }

    /// <summary>
    /// รหัสโครงการ
    /// </summary>
    public int nProjectID { get; set; }

    /// <summary>
    /// รหัสตัวชี้วัด (รหัส TM_Indicator)
    /// </summary>
    public int nIndicatorID { get; set; }

    /// <summary>
    /// ชื่อตัวชี้วัด
    /// </summary>
    public string? sIndicatorName { get; set; }

    public string? sOther { get; set; }

    public int nOrder { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
