using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_ResultBudget_History
{
    public int nAreaResultBudgetID_His { get; set; }

    /// <summary>
    /// รหัสหลักตารางงบประมาณที่ใช้จริงที่ผูกกับรายพื้นที่
    /// </summary>
    public int nAreaResultBudgetID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    public int nAroundUpdate { get; set; }

    public int nYear { get; set; }

    public decimal? nResultBudget { get; set; }

    public string? sDrescription { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
