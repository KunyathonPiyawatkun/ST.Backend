using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_Agency
{
    /// <summary>
    /// รหัสหน่วยงาน
    /// </summary>
    public int AgencyID { get; set; }

    /// <summary>
    /// ชื่อหน่วยงาน
    /// </summary>
    public string AgencyName { get; set; } = null!;

    public string? sUnitCode { get; set; }

    public bool IsActive { get; set; }

    public int nOrder { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
