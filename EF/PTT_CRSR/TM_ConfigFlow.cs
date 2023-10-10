using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_ConfigFlow
{
    public int sRequestType { get; set; }

    public int nGroupID { get; set; }

    public string? sSubmit { get; set; }

    public string? sCancel { get; set; }

    public string? sApprove { get; set; }

    public string? sReject { get; set; }

    public string? sRework { get; set; }

    public string? sDelegate { get; set; }

    public string? sNeedInfo { get; set; }

    public string? sPostToSAP { get; set; }

    public string? sInputMode { get; set; }

    public string? sHR { get; set; }
}
