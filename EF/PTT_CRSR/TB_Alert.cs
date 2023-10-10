using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Alert
{
    /// <summary>
    /// รหัสหลักตารางการแจ้งเตือนการอัพเดต Progress
    /// </summary>
    public int nAlertID { get; set; }

    /// <summary>
    /// รหัสรอบการแจ้งเตือน
    /// </summary>
    public int nUpdateProgressID { get; set; }

    /// <summary>
    /// รอบที่
    /// </summary>
    public int nRound { get; set; }

    /// <summary>
    /// วันที่ส่งอีเมลแจ้งเตือน
    /// </summary>
    public DateTime dDate { get; set; }

    public TimeSpan tTime { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
