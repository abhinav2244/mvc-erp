using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class AcdActivityPlanMaster
{
    public int CId { get; set; }

    public string? ActivityNm { get; set; }

    public string? Subject { get; set; }

    public string? ClassId { get; set; }

    public int? BranchCode { get; set; }

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public string? ClassLevel { get; set; }

    public int? EmpId { get; set; }

    public string? Status { get; set; }
}
