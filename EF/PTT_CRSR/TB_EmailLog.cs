using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_EmailLog
{
    public long nLogEmailID { get; set; }

    public int? nReferanceID { get; set; }

    public int? nTempleteID { get; set; }

    public DateTime dLogEmail { get; set; }

    public string sFrom { get; set; } = null!;

    public string? sDebugFrom { get; set; }

    public string sTo { get; set; } = null!;

    public string? sDebugTo { get; set; }

    public string? sCC { get; set; }

    public string? sDebugCC { get; set; }

    public string? sBCC { get; set; }

    public string? sDebugBCC { get; set; }

    public string? sSubject { get; set; }

    public string? sContent { get; set; }

    public bool IsSuccess { get; set; }

    public string? sErrorMsg { get; set; }
}
