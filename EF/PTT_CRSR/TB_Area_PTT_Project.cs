using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_PTT_Project
{
    /// <summary>
    /// รหัสหลักตารางโครงการพัฒนาของ ปตท. และกลุ่ม ปตท. ในอดีต
    /// </summary>
    public int nAreaPTTProjectID { get; set; }

    /// <summary>
    /// รหัสพื้่นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// รหัสโครงการพัฒนาของ ปตท. (TM_Data)
    /// </summary>
    public int nPTTProjectID { get; set; }

    /// <summary>
    /// ชื่อโครงการพัฒนาของ ปตท. (TM_Data)
    /// </summary>
    public string? sPTTProjectName { get; set; }

    public string? sOther { get; set; }

    public int nOrder { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
