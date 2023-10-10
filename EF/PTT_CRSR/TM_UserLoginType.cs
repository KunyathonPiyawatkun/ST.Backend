using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_UserLoginType
{
    /// <summary>
    /// User Login Type ID
    /// </summary>
    public int nUserLoginTypeID { get; set; }

    /// <summary>
    /// User Login Name
    /// </summary>
    public string sUserLoginName { get; set; } = null!;

    /// <summary>
    /// Sort Order
    /// </summary>
    public int? nOrder { get; set; }

    /// <summary>
    /// 1 = Active, 0 = Inactive
    /// </summary>
    public bool? IsActive { get; set; }
}
