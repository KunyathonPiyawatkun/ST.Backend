using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_User
{
    public int nUserID { get; set; }

    /// <summary>
    /// รหัสประเภทผู้ใช้งาน (TM_DataType.DataTypeID = 1)
    /// </summary>
    public int nUserTypeID { get; set; }

    /// <summary>
    /// รหัสพนักงาน
    /// </summary>
    public int? nEmployeeID { get; set; }

    /// <summary>
    /// ตำแหน่ง
    /// </summary>
    public string sName { get; set; } = null!;

    public string sSureName { get; set; } = null!;

    /// <summary>
    /// ตำแหน่ง
    /// </summary>
    public string sPosition { get; set; } = null!;

    /// <summary>
    /// แผนก
    /// </summary>
    public string nDepartment { get; set; } = null!;

    public string sEmail { get; set; } = null!;

    public string? sPhoneNumber { get; set; }

    /// <summary>
    /// หน่วยงานที่สังกัด
    /// </summary>
    public int nAgencyID { get; set; }

    public string? sUsername { get; set; }

    public string? sPassword { get; set; }

    public bool IsLoginChangePassword { get; set; }

    public DateTime? dChangePasswordDate { get; set; }

    public int nOrder { get; set; }

    public bool IsActive { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
