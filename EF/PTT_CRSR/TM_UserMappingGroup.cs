using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_UserMappingGroup
{
    public int nEmployeeID { get; set; }

    /// <summary>
    /// Refer.TM_UserGroup
    /// </summary>
    public int nUserGroupID { get; set; }
}
