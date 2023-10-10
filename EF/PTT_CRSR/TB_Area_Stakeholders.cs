using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_Stakeholders
{
    /// <summary>
    /// รหัสหลักของตารางผู้มีส่วนได้ส่วนเสียของพื้นที่
    /// </summary>
    public int nAreaStakeholdersID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// รหัสผู้มีส่วนได้ส่วนเสีย (TM_Stakeholders)
    /// </summary>
    public int nStakeholdersID { get; set; }

    /// <summary>
    /// ชื่อผู้มีส่วนได้ส่วนเสีย (TM_Stakeholders)
    /// </summary>
    public string? sStakeholdersName { get; set; }

    public int nOrder { get; set; }

    /// <summary>
    /// ตำแหน่ง
    /// </summary>
    public string? sPosition { get; set; }

    /// <summary>
    /// สังกัด
    /// </summary>
    public string? sAffiliation { get; set; }

    /// <summary>
    /// หมายเลขโทรศัพท์
    /// </summary>
    public string? sPhoneNumber { get; set; }

    public string? sAddress { get; set; }

    public string? sRemark { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
