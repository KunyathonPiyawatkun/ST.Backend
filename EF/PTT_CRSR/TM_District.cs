using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_District
{
    public int nDistrictID { get; set; }

    public string sDistrictNameTH { get; set; } = null!;

    public string sDistrictNameEN { get; set; } = null!;

    public int nProvinceID { get; set; }
}
