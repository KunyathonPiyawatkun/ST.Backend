using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_Image
{
    public int nAreaImageID { get; set; }

    public int nAreaID { get; set; }

    public int nYear { get; set; }

    /// <summary>
    /// ประเภทรูปภาพ
    /// </summary>
    public int? nAreaImageTypeID { get; set; }

    /// <summary>
    /// รอบที่ Update Progress
    /// </summary>
    public int nRoundUpdate { get; set; }

    public string sImagePath { get; set; } = null!;

    public string? sSystemName { get; set; }

    public string? sExpireName { get; set; }

    public int nOrder { get; set; }

    public string? sDrescription { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
