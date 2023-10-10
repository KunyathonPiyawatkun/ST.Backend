using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Project_SDGsSecondary_History
{
    public int nProjectSDGsSecondaryID_His { get; set; }

    /// <summary>
    /// รหัสหลักของตาราง SDG รองของโครงการ
    /// </summary>
    public int nProjectSDGsSecondaryID { get; set; }

    /// <summary>
    /// รหัสโครงการ
    /// </summary>
    public int nProjectID { get; set; }

    /// <summary>
    /// รหัส SDG (รหัสจาก TM_SDGs)
    /// </summary>
    public int nSDGsSecondaryID { get; set; }

    /// <summary>
    /// ชื่อ SDG (รหัสจาก TM_SDGs)
    /// </summary>
    public string? sSDGsSecondaryName { get; set; }

    public string? sOther { get; set; }

    public int nOrder { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
