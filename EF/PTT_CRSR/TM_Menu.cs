using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_Menu
{
    public int nMenuID { get; set; }

    public int? nParentID { get; set; }

    public string? sMenuName { get; set; }

    public int? nLevel { get; set; }

    public string? sRoute { get; set; }

    public string? sIcon { get; set; }

    public bool IsDisplay { get; set; }

    public bool IsView { get; set; }

    public bool IsEdit { get; set; }

    public bool IsSetPRMS { get; set; }

    public decimal? nMenuOrder { get; set; }

    public bool IsActive { get; set; }

    public bool IsFrontend { get; set; }
}
