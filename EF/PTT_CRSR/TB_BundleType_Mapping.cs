using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_BundleType_Mapping
{
    /// <summary>
    /// รหัสประเภทการรวมกลุ่ม (TM_Master)
    /// </summary>
    public int nBundleType { get; set; }

    /// <summary>
    /// รหัสลักษณะการรวมกลุ่ม (TM_Master)
    /// </summary>
    public int nNatureGrouping { get; set; }
}
