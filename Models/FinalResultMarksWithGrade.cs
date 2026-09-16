using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class FinalResultMarksWithGrade
{
    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? MotherName { get; set; }

    public string? CollegeCode { get; set; }

    public string? EnrollmentNumber { get; set; }

    public int? ExamFormId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public int? Total { get; set; }

    public int? MinimumMarks { get; set; }

    public string? SubjectType { get; set; }

    public double? FinalTotal { get; set; }

    public double? AppliedGrace { get; set; }

    public double? AppliedCondo { get; set; }

    public string? Result { get; set; }

    public string? FinalResult { get; set; }

    public int? ExamSubjectId { get; set; }

    public string? RollNumber { get; set; }

    public double? ObtMarksThinternalMarks { get; set; }

    public double? ObtMarksThexternal { get; set; }

    public double? ObtMarksPrexternal { get; set; }

    public double? PracticalInternal { get; set; }

    public string? SubjectCode { get; set; }

    public double? OutofMarks { get; set; }

    public double? X { get; set; }

    public string? NoColumnName { get; set; }

    public double? Sumoftotal { get; set; }

    public double? N { get; set; }

    public double? M { get; set; }

    public double? Xm { get; set; }

    public double? XM2 { get; set; }

    public bool? IsAbsentThexternal { get; set; }

    public bool? IsAbsentPrexternal { get; set; }

    public string? Ft { get; set; }

    public string? Mm { get; set; }
}
