using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_Product
{
    /// <summary>
    /// รหัสหลักตารางข้อมูลผลิตภัณฑ์ของพื้นที่
    /// </summary>
    public int nAreaProductID { get; set; }

    public int nAreaID { get; set; }

    public int nProductID { get; set; }

    public string? sProductName { get; set; }

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
