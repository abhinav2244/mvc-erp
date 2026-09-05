using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Employeewithleaverecord
{
    public int? Id { get; set; }

    public string? BranchName { get; set; }

    public string? SubmitDate { get; set; }

    public string? UserId { get; set; }

    public string? Name { get; set; }

    public string? LeaveName { get; set; }

    public string? Reason { get; set; }
}
