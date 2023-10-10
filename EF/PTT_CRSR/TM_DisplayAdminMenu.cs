using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_DisplayAdminMenu
{
    /// <summary>
    /// รหัส Master Data
    /// </summary>
    public int DisplayAdminMenuID { get; set; }

    /// <summary>
    /// จำนวน
    /// </summary>
    public int nQuantity { get; set; }

    public DateTime dUpdate { get; set; }

    public bool IsActive { get; set; }
}
