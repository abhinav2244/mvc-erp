using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Branchmaster
{
    public int BranchCode { get; set; }

    public short? CourseGrId { get; set; }

    public string? Subgroup { get; set; }

    public string? BranchName { get; set; }

    public string? ClassLevel { get; set; }

    public string? BranchAbbr { get; set; }
}
