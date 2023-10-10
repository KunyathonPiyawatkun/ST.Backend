using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_Indicator
{
    /// <summary>
    /// รหัสตัวชี้วัด
    /// </summary>
    public int nIndicatorID { get; set; }

    /// <summary>
    /// ชื่อตัวชี้วัด
    /// </summary>
    public string sIndicatorName { get; set; } = null!;

    /// <summary>
    /// หน่วยตัวชี้วัด
    /// </summary>
    public string nUnit { get; set; } = null!;

    public string? sDrescription { get; set; }

    public int nOrder { get; set; }

    public bool IsActive { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
