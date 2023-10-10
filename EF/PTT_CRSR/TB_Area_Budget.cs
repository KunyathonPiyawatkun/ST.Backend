using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_Budget
{
    /// <summary>
    /// รหัสหลักตารางข้อมูลงบประมาณตั้งต้นของพื้นที่
    /// </summary>
    public int nAreaBudgetID { get; set; }

    public int nAreaID { get; set; }

    public int nYear { get; set; }

    public decimal? nAreaBudget { get; set; }

    public string? sDescription { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
