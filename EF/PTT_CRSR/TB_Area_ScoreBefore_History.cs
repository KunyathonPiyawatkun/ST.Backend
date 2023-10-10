using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_ScoreBefore_History
{
    public int nAreaScoreBeforeID_His { get; set; }

    /// <summary>
    /// รหัสหลักตารางคะแนนก่อนการดำเนินงานที่ผูกกับพื้นที่
    /// </summary>
    public int nAreaScoreBeforeID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// รหัสประเภทคะแนน (TM_data)
    /// </summary>
    public int nScoreTypeID { get; set; }

    /// <summary>
    /// ชื่อประเภทคะแนน (TM_data)
    /// </summary>
    public string? sScoreTypeName { get; set; }

    public string? sOther { get; set; }

    public string? nProjectScoreBefore { get; set; }

    public int nOrder { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
