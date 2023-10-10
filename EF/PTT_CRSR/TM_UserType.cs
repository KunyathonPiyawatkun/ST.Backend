using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_UserType
{
    /// <summary>
    /// User Type ID
    /// </summary>
    public int nUserTypeID { get; set; }

    /// <summary>
    /// User Type Name
    /// </summary>
    public string sUserTypeName { get; set; } = null!;

    /// <summary>
    /// Sort Order
    /// </summary>
    public int? nOrder { get; set; }

    /// <summary>
    /// 1 = Active, 0 = Inactive
    /// </summary>
    public bool? IsActive { get; set; }
}
