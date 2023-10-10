using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_OccupationGroup
{
    /// <summary>
    /// รหัสตารางกลุ่มอาชีพ
    /// </summary>
    public int nAreaOccupationGroupID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// รหัสประเภทกลุ่มอาชีพ (หลัก/รอง) (TM_Data.nDataTypeID = 3)
    /// </summary>
    public int nOccupationTypeID { get; set; }

    /// <summary>
    /// รหัสกลุ่มอาชีพ
    /// </summary>
    public int nOccupationGroupID { get; set; }

    /// <summary>
    /// ชื่อกลุ่มอาชีพ
    /// </summary>
    public string nOccupationGroupName { get; set; } = null!;

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
