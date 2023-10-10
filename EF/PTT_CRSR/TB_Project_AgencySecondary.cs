using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Project_AgencySecondary
{
    /// <summary>
    /// รหัสหลักตารางหน่วยงานที่รับผิดชอบรอง
    /// </summary>
    public int nProjectAgencySecondaryID { get; set; }

    /// <summary>
    /// รหัสโครงการ
    /// </summary>
    public int nProjectID { get; set; }

    /// <summary>
    /// รหัสหน่วยงานที่รับผิดชอบ (เอารหัสจาก TM_Agency)
    /// </summary>
    public int nAgencyID { get; set; }

    /// <summary>
    /// ชื่อหน่วยงานที่รับผิดชอบ (TM_Agency)
    /// </summary>
    public string? sAgencyName { get; set; }

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
