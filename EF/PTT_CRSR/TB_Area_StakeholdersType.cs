using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_StakeholdersType
{
    /// <summary>
    /// รหัสตารางผู้มีส่วนได้ส่วนเสียที่อยู่ในพื้นที่ (TB_Area_Stakeholders)
    /// </summary>
    public int nAreaStakeholdersTypeID { get; set; }

    /// <summary>
    /// รหัสประเภทผู้มีส่วนได้ส่วนเสีย (รหัสจาก TM_Data)
    /// </summary>
    public int nStakeholdersTypeID { get; set; }

    /// <summary>
    /// ชื่อประเภทผู้มีส่วนได้ส่วนเสีย (รหัสจาก TM_Data)
    /// </summary>
    public string? sStakeholdersTypeName { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
