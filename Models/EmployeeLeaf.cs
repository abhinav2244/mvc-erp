using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class EmployeeLeaf
{
    public int LeaveAppId { get; set; }

    public string? LeaveAppCode { get; set; }

    public int? LeaveEmpid { get; set; }

    public int? LeaveDsg { get; set; }

    public string? LeaveDept { get; set; }

    public DateTime? LeaveFrom { get; set; }

    public DateTime? LeaveTo { get; set; }

    public string? LeaveType { get; set; }

    public string? LeaveReason { get; set; }

    public int? LeaveNo { get; set; }

    public string? LeaveReporting { get; set; }

    public DateTime? LeaveAppDate { get; set; }

    public int? LeaveTotal { get; set; }

    public int? LeaveRemains { get; set; }

    public string? LeaveDocAttach { get; set; }

    public byte[]? LeaveSignature { get; set; }

    public string? LeaveIsDelete { get; set; }
}
