using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Studfeedback
{
    public int Sno { get; set; }

    public string? BranchName { get; set; }

    public string? Semester { get; set; }

    public string? Teacher { get; set; }

    public string? Subject { get; set; }

    public string? Section { get; set; }

    public string? ClassId { get; set; }

    public int? EmpId { get; set; }

    public string? DesignationId { get; set; }

    public string? BranchCode { get; set; }

    public string? AcadYear { get; set; }

    public string? ThorPr { get; set; }

    public string? Classlevel { get; set; }
}
