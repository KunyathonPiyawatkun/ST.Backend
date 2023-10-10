using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_Agriculture_History
{
    public int nAreaAgricultureID_His { get; set; }

    /// <summary>
    /// รหัสหลักตารางข้อมูลการเกษตรของพื้นที่
    /// </summary>
    public int nAreaAgricultureID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// รหัสข้อมูลการเกษตร (TM_Data)
    /// </summary>
    public int nAgricultureID { get; set; }

    public string? sAgricultureName { get; set; }

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
