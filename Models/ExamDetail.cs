using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamDetail
{
    public int? Id { get; set; }

    public int? StudId { get; set; }

    public string? AcadYear { get; set; }

    public string? ExamApp { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public int? BranchCode { get; set; }

    public string? Theory { get; set; }

    public string? Practical { get; set; }

    public string? Status { get; set; }

    public string? ClassLevel { get; set; }

    public string? FeePaid { get; set; }
}
