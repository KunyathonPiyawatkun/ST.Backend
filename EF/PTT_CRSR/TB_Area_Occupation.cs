using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_Occupation
{
    /// <summary>
    /// รหัสตารางเก็บอาชีพพื้นที่
    /// </summary>
    public int nAreaOccupationID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// รหัสกลุ่มอาชีพ
    /// </summary>
    public int nOccupationgGroupID { get; set; }

    /// <summary>
    /// รหัสอาชีพ
    /// </summary>
    public int nOccupationID { get; set; }

    /// <summary>
    /// ชื่ออาชีพ
    /// </summary>
    public string? sOccupationName { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
