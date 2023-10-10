using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Project_Budget
{
    /// <summary>
    /// รหัสหลักตารางงบประมาณตั้งต้นโครงการ
    /// </summary>
    public int nProjectBudgetID { get; set; }

    /// <summary>
    /// รหัสโครงการ
    /// </summary>
    public int nProjectID { get; set; }

    public int nYear { get; set; }

    /// <summary>
    /// งบประมาณตั้งต้นของโครงการแต่ละปี
    /// </summary>
    public decimal? nProjectBudget { get; set; }

    public string? sDrescription { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
