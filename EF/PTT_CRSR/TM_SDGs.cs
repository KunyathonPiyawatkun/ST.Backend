using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_SDGs
{
    /// <summary>
    /// รหัส SDGs
    /// </summary>
    public int nSDGsID { get; set; }

    public string? nSDGsName { get; set; }

    public string sPath { get; set; } = null!;

    public string sSystemFileName { get; set; } = null!;

    public string sFileName { get; set; } = null!;

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
