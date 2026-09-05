using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstDuplicateMarksheetAppl
{
    public int Dmid { get; set; }

    public int? StudId { get; set; }

    public int? ExamId { get; set; }

    public string? MarksheetSemester { get; set; }

    public string? MarksheetClass { get; set; }

    public string? RollNumber { get; set; }

    public DateOnly? AppliedDate { get; set; }

    public DateOnly? ApproveDate { get; set; }

    public string? ApplicationStatus { get; set; }

    public string? StudRemark { get; set; }

    public string? Coeremark { get; set; }

    public bool? IsDelete { get; set; }
}
