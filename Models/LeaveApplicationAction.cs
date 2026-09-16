using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class LeaveApplicationAction
{
    public int ActId { get; set; }

    public DateTime? ActDt { get; set; }

    public int? ApplId { get; set; }

    public string? ApplCode { get; set; }

    public int? ForwardByEmpId { get; set; }

    public int? ActTakenByEmpId { get; set; }

    public string? ActTaken { get; set; }

    public string? ActReason { get; set; }

    public int? ForwardToEmpId { get; set; }

    public string Status { get; set; } = null!;
}
