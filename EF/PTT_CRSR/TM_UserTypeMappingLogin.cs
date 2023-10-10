using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_UserTypeMappingLogin
{
    /// <summary>
    /// Refer.TM_UserType
    /// </summary>
    public int nUserTypeID { get; set; }

    /// <summary>
    /// Refer.TM_UserLoginType
    /// </summary>
    public int nUserLoginTypeID { get; set; }
}
