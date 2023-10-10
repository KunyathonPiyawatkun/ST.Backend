using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Project_ResultBudget_History
{
    public int nProjectResultBudgetID_His { get; set; }

    /// <summary>
    /// รหัสหลักตารางข้อมูลงบประมาณที่ใช้จริง (กรณีงบประมาณ เป็นประเภท รวมโครงการ)
    /// </summary>
    public int nProjectResultBudgetID { get; set; }

    public int nProjectID { get; set; }

    /// <summary>
    /// รอบที่อัพเดต
    /// </summary>
    public int nAroundUpdate { get; set; }

    /// <summary>
    /// ปี
    /// </summary>
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
