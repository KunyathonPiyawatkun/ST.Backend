using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_Stakeholders
{
    public int nStakeholdersID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public string sStakeholdersName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? dCreate { get; set; }

    public int? nCreateBy { get; set; }

    public DateTime? dUpdate { get; set; }

    public int? nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool? IsDelete { get; set; }
}
