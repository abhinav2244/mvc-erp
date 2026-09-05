using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class WorkSheetForward
{
    public int WsfId { get; set; }

    public int? WsId { get; set; }

    public int? ForwardByEmpId { get; set; }

    public int? ForwardToEmpId { get; set; }

    public string? FwdWork { get; set; }

    public DateTime? FwdDateTime { get; set; }

    public string? Status { get; set; }
}
