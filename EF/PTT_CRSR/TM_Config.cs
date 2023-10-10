using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_Config
{
    public int nConfig_ID { get; set; }

    /// <summary>
    /// ชื่อ ของ Config
    /// </summary>
    public string? sConfig_Name { get; set; }

    /// <summary>
    /// ข้อมูลที่ต้องการ Config สำหรับข้อมูลที่เป็นประเภท Datetime
    /// </summary>
    public DateTime? dConfig_Datetime { get; set; }

    /// <summary>
    /// ข้อมูลที่ต้องการ Config สำหรับข้อมูลที่เป็นประเภท Varchar
    /// </summary>
    public string? sConfig_Varchar { get; set; }

    /// <summary>
    /// ข้อมูลที่ต้องการ Config สำหรับข้อมูลที่เป็นประเภท Int
    /// </summary>
    public int? nConfig_Int { get; set; }

    /// <summary>
    /// ข้อมูลที่ต้องการ Config สำหรับข้อมูลที่เป็นประเภท Bit
    /// </summary>
    public bool? IsConfig_Bit { get; set; }

    /// <summary>
    /// คำอธิบายของ Config
    /// </summary>
    public string? sConfig_Description { get; set; }
}
