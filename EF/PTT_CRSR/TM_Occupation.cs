using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_Occupation
{
    /// <summary>
    /// รหัสอาชีพ
    /// </summary>
    public int nOccupationID { get; set; }

    public string sOccupationName { get; set; } = null!;

    public int nOrder { get; set; }

    public int? nParent { get; set; }

    public string? sDescription { get; set; }

    public bool IsActive { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dCraeteDate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int? nDeleteBy { get; set; }

    public DateTime? dDelete { get; set; }

    public bool IsDelete { get; set; }
}
