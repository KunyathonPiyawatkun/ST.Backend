using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Area_File
{
    /// <summary>
    /// รหัสไฟล์ของเอกสารพื้่นที่
    /// </summary>
    public int nAreaFileID { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public int nAreaID { get; set; }

    /// <summary>
    /// ประเภทเอกสาร
    /// </summary>
    public int nFileTypeID { get; set; }

    public string sPath { get; set; } = null!;

    public string? sSystemFilename { get; set; }

    public string? sFilename { get; set; }

    public int nOrder { get; set; }

    public string? sDrescription { get; set; }

    public DateTime dCreate { get; set; }

    public int nCreateBy { get; set; }

    public DateTime dUpdate { get; set; }

    public int nUpdateBy { get; set; }

    public DateTime? dDelete { get; set; }

    public int? nDeleteBy { get; set; }

    public bool IsDelete { get; set; }
}
