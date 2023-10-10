using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_UserMappingRole
{
    /// <summary>
    /// Refer.TB_Employee
    /// </summary>
    public int nEmployeeID { get; set; }

    /// <summary>
    /// Refer.TM_UserRole
    /// </summary>
    public int nUserRoleID { get; set; }
}
