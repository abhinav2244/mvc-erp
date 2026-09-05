using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BranchWiseEmployee
{
    public long Id { get; set; }

    public int? EmpCode { get; set; }

    public string? DeptCode { get; set; }

    public int? BranchCode { get; set; }

    public bool? IdDelete { get; set; }
}
