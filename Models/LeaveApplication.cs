using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class LeaveApplication
{
    public int ApplId { get; set; }

    public string? ApplCode { get; set; }

    public DateTime? ApplDate { get; set; }

    public int? LempId { get; set; }

    public string? LempDept { get; set; }

    public int? LempDsg { get; set; }

    public string? LempType { get; set; }

    public DateTime? LeaveFromDt { get; set; }

    public DateTime? LeaveToDt { get; set; }

    public double? LeaveNoCount { get; set; }

    public string? LeaveType { get; set; }

    public string? LeaveReason { get; set; }

    public string? LeaveDocAttach { get; set; }

    public string? LeaveSignature { get; set; }

    public int? ForwardToEmpId { get; set; }
}
