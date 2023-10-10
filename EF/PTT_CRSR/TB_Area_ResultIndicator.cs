using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_ResultIndicator
{
    /// <summary>
    /// รหัสหลักตารางผลลัพธ์ตัวชี้วัดพื้นที่
    /// </summary>
    public int nAreaResultIndicatorID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// รอบการอัพเดต
    /// </summary>
    public int nAroundUpdate { get; set; }

    /// <summary>
    /// ปี
    /// </summary>
    public int nYear { get; set; }

    /// <summary>
    /// รหัสตัวชี้วัด (TM_Stakeholders)
    /// </summary>
    public int nIndicatorID { get; set; }

    public string? sIndicatorName { get; set; }

    /// <summary>
    /// ผลลัพธ์
    /// </summary>
    public int? nResultIndecator { get; set; }

    public string? sDescroption { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
