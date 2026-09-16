using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class IssueExamMarksheet
{
    public int Iemid { get; set; }

    public string? AcadYear { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public int? StudId { get; set; }

    public string? EnrollmentNumber { get; set; }

    public bool? IsssuedStatus { get; set; }

    public bool? IsDelete { get; set; }
}
