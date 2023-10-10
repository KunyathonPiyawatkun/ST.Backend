using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_Data
{
    public int nDataID { get; set; }

    public int nDataTypeID { get; set; }

    public string sNameTH { get; set; } = null!;

    public string? sNameEN { get; set; }

    public string? sAbbr { get; set; }

    public int nOrder { get; set; }

    public string? sDescription { get; set; }

    public int? nParentDataID { get; set; }

    public bool IsActive { get; set; }

    public int? nCreateBy { get; set; }

    public DateTime? dCraeteDate { get; set; }

    public int? nUpdateBy { get; set; }

    public DateTime? dUpdate { get; set; }

    public int? nDelete { get; set; }

    public DateTime? dDelete { get; set; }

    public bool IsDelete { get; set; }
}
