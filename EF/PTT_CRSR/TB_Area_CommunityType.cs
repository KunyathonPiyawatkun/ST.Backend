using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_CommunityType
{
    /// <summary>
    /// รหัสหลักตารางประเภทชุมชน
    /// </summary>
    public int nAreaCommunityTypeID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// รหัสประเภทชุมชน (TM_Data)
    /// </summary>
    public int nCommunityTypeID { get; set; }

    /// <summary>
    /// ชื่อประเภทชุมชน (TM_Data)
    /// </summary>
    public int? sCommunityTypeName { get; set; }

    public int nOrder { get; set; }

    public string? sOther { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
