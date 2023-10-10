using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_ResultScore_History
{
    public int nAreaResultScoreID_His { get; set; }

    public int nAreaResultScoreID { get; set; }

    public int nAreaID { get; set; }

    public int nAroundUpdate { get; set; }

    public int nYear { get; set; }

    /// <summary>
    /// รหัสประเภทคะแนน (TM_data)
    /// </summary>
    public int nScoreTypeID { get; set; }

    /// <summary>
    /// ชื่อประเภทคะแนน (TM_data)
    /// </summary>
    public string? sScoreTypeName { get; set; }

    public int? nResultScore { get; set; }

    public string? sDescription { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
