using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_DataType
{
    /// <summary>
    /// รหัสหประเภทข้อมูล
    /// </summary>
    public int nDataTypeID { get; set; }

    /// <summary>
    /// ชื่อข้อมูล
    /// </summary>
    public string sNameTH { get; set; } = null!;

    public string? sNameEN { get; set; }

    /// <summary>
    /// รายละเอียดข้อมูล
    /// </summary>
    public string? sDescription { get; set; }

    public bool IsAdd { get; set; }

    public bool IsOrder { get; set; }

    public bool IsAllowManage { get; set; }

    public bool IsHasParent { get; set; }

    public int? nParentDataTypeID { get; set; }

    public int? nCreateBy { get; set; }

    public DateTime? dCraeteDate { get; set; }

    public int? nUpdateBy { get; set; }

    public DateTime? dUpdate { get; set; }

    public int? nDeleteBy { get; set; }

    public DateTime? dDelete { get; set; }

    public bool IsDelete { get; set; }
}
