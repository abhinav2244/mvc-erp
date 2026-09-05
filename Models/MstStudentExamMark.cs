using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStudentExamMark
{
    public int ExamMarksId { get; set; }

    public string? AcadYear { get; set; }

    public string? ClassLevel { get; set; }

    public int? BranchCode { get; set; }

    public string? Class { get; set; }

    public string? Semester { get; set; }

    public int? StudId { get; set; }

    public string? UnivBoard { get; set; }

    public string? RollNo { get; set; }

    public string? ExamYear { get; set; }

    public string? ExamResult { get; set; }

    public double? ObtainMarks { get; set; }

    public double? TotalMarks { get; set; }

    public double? Percentage { get; set; }

    public double? Sgpa { get; set; }

    public byte? NoOfAttempts { get; set; }

    public byte? GapInYears { get; set; }

    public string? Type { get; set; }
}
