using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_Provinces
{
    public int nProvinceID { get; set; }

    public string? sProvinceNameTH { get; set; }

    public string? sProvinceShort { get; set; }

    public string? sProvinceNameEN { get; set; }

    public int? nGeographyID { get; set; }
}
