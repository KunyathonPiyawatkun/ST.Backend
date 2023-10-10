using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Project_ResultScore
{
    /// <summary>
    /// รหัสหลักตารางคะแนนหลังดำเนินการ กรณีที่ Update Progress ที่โครงการ
    /// </summary>
    public int nProjectResultScoreID { get; set; }

    /// <summary>
    /// รหัสโครงการ
    /// </summary>
    public int nProjectID { get; set; }

    /// <summary>
    /// รอบการอัพเดต
    /// </summary>
    public int nAroundUpdate { get; set; }

    /// <summary>
    /// ปี
    /// </summary>
    public int nYear { get; set; }

    /// <summary>
    /// รหัสประเภทคะแนน (TM_data.nDataTypeID = 2) 
    /// </summary>
    public int nScoreTypeID { get; set; }

    /// <summary>
    /// ชื่อประเภทคะแนน (TM_Data)
    /// </summary>
    public string? sScoreTypeName { get; set; }

    /// <summary>
    /// คะแนนหลังดำเนินการ
    /// </summary>
    public int? nResultScore { get; set; }

    public string? sDescription { get; set; }

    public int nOrder { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
