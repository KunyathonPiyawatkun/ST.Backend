using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_Geography_History
{
    public int nAreaGeographyID_His { get; set; }

    /// <summary>
    /// รหัสหลักตารางลักษณะทางภูมิศาสตร์ 
    /// </summary>
    public int nAreaGeographyID { get; set; }

    public int nAreaID { get; set; }

    public int nOrder { get; set; }

    /// <summary>
    /// ลักษณะทางภูมิศาสตร์ (TM_Data)
    /// </summary>
    public int nGeographyID { get; set; }

    public string? sGeographyName { get; set; }

    public string? sOther { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
