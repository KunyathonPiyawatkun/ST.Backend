using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_BundleType
{
    /// <summary>
    /// รหัสหลักข้อมูลประเทภการรวมกลุ่มของพื้นที่
    /// </summary>
    public int nAreaBundleTypeID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// รหัสประเภทการรวมกลุ่ม
    /// </summary>
    public int nBundleTypeID { get; set; }

    public string? sBundleTypeName { get; set; }

    /// <summary>
    /// รหัสลักษณะการรวมกลุ่ม
    /// </summary>
    public int nNatureGroupingID { get; set; }

    public string? sNatureGroupingName { get; set; }

    public int nOrder { get; set; }

    public string? sOther { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
