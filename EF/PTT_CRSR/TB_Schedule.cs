using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TB_Schedule
{
    public int nScheduleID { get; set; }

    public string? sDetail { get; set; }

    public DateTime dLogStart { get; set; }

    public DateTime dLogEnd { get; set; }

    public bool IsSuccess { get; set; }

    public string? sErrorMessage { get; set; }

    public string? sStackTrace { get; set; }
}
