using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_LoginType
{
    /// <summary>
    /// Login Type ID
    /// </summary>
    public int nLoginTypeID { get; set; }

    /// <summary>
    /// Login Type Name
    /// </summary>
    public string sLoginTypeName { get; set; } = null!;

    /// <summary>
    /// Url
    /// </summary>
    public string? sUrl { get; set; }

    /// <summary>
    /// 1 = Active, 0 = Inactive
    /// </summary>
    public bool? IsActive { get; set; }
}
