using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class EmpMaxLeavesDetail
{
    public int? EmployeeId { get; set; }

    public string? LeaveType { get; set; }

    public string? AcadYear { get; set; }

    public double? MaxLeaves { get; set; }
}
