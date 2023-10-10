using System;
using System.Collections.Generic;

namespace ST_API.EF.PTT_CRSR;

public partial class TM_Status
{
    public int nStatusID { get; set; }

    public int nRequestTypeID { get; set; }

    public string? sStatusName { get; set; }

    public int? nNextStatusID { get; set; }

    public string? sNextStatusName { get; set; }

    public string? sDescription { get; set; }

    public int? nOrder { get; set; }
}
