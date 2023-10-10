using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Approve
{
    public int nRequestID { get; set; }

    /// <summary>
    /// รหัสพนักงานของผู้จัดการส่วน ที่อนุมัติใบงาน
    /// </summary>
    public string? sDV_ID { get; set; }

    public string? sDV_Name { get; set; }

    /// <summary>
    /// รหัสพนักงานของผู้จัดการฝ่าย ที่อนุมัติใบงาน
    /// </summary>
    public string? sVP_ID { get; set; }

    public string? sVP_Name { get; set; }
}
