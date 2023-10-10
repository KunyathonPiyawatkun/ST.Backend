using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Project_AgencyCooperation_History
{
    public int nProjectAgencyCooperationID_His { get; set; }

    /// <summary>
    /// รหัสหลักตารางหน่วยงานที่ให้ความร่วมมือโครงการ
    /// </summary>
    public int nProjectAgencyCooperationID { get; set; }

    /// <summary>
    /// รหัสโครงการ
    /// </summary>
    public int nProjectID { get; set; }

    /// <summary>
    /// รหัสหน่วยงานที่ให้ความร่วมมือ (TM_Data)
    /// </summary>
    public int nAgencyCooperationID { get; set; }

    /// <summary>
    /// ชื่อหน่วยงานที่ให้ความร่วมมือ (TM_Data)
    /// </summary>
    public string? sAgencyCooperationName { get; set; }

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
