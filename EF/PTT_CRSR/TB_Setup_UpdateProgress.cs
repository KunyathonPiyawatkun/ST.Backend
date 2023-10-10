using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Setup_UpdateProgress
{
    public int nUpdateProgressID { get; set; }

    public int nYear { get; set; }

    /// <summary>
    /// รอบที่
    /// </summary>
    public int nRound { get; set; }

    public DateTime dStartDate { get; set; }

    public DateTime dEndDate { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
