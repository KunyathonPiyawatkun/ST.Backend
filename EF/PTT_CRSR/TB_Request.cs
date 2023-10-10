using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Request
{
    public int nRequestID { get; set; }

    /// <summary>
    /// รหัสประเภทคำขอ (TM_RequestType)
    /// </summary>
    public int? nRequestTypesID { get; set; }

    public int nAreaID { get; set; }

    public int nStatus { get; set; }

    public string? sComment { get; set; }

    /// <summary>
    /// รหัสผู้จัดการส่วน กสญ. ที่ต้องส่งอีเมลเมื่อ WorkFlow Approve Success
    /// </summary>
    public bool? IsSendEmail_DV { get; set; }

    /// <summary>
    /// รหัสผู้จัดการฝ่าย กสญ. ที่ต้องส่งอีเมลเมื่อ WorkFlow Approve Success
    /// </summary>
    public bool? IsSendEmail_VP { get; set; }

    /// <summary>
    /// รหัสผู้ช่วย กสญ. ที่ต้องส่งอีเมลเมื่อ WorkFlow Approve Success
    /// </summary>
    public bool? IsSendEmail_AE { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public int? nDeleteBy { get; set; }

    public DateTime? dDelete { get; set; }

    public bool IsDelete { get; set; }
}
