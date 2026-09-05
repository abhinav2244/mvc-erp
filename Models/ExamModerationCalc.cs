using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamModerationCalc
{
    public string? Name { get; set; }

    public string? MotherName { get; set; }

    public string? Gender { get; set; }

    public string? CollegeCode { get; set; }

    public string? EnrollmentNumber { get; set; }

    public int? ExamFormId { get; set; }

    public int? ExamId { get; set; }

    public int? Total { get; set; }

    public int? MinimumMarks { get; set; }

    public string? SubjectType { get; set; }

    public double? FinalTotal { get; set; }

    public double? AppliedGrace { get; set; }

    public string? AppliedCondo { get; set; }

    public string? Result { get; set; }

    public string? FinalResult { get; set; }

    public string? OverallResult { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamSubjectId { get; set; }

    public string? RollNumber { get; set; }

    public double? ObtMarksThinternalMarks { get; set; }

    public double? ObtMarksThexternal { get; set; }

    public double? ObtMarksPrexternal { get; set; }

    public double? PracticalInternal { get; set; }

    public string? SubjectCode { get; set; }

    public string? RptSubject { get; set; }

    public string? CollegeName { get; set; }

    public string? ExamName { get; set; }

    public double? FinalOutOf { get; set; }

    public double? TotalMarks { get; set; }

    public double? ObtMarksThexternalReassessment { get; set; }

    public bool? IsReassessment { get; set; }

    public double? ReassessmentMarks { get; set; }

    public double? SubTotalMarks { get; set; }

    public double? TotalObtainedMarks { get; set; }

    public double? SubFinalTotalReassementMarks { get; set; }

    public double? OutOfmarksReassesment { get; set; }

    public string? SubResult { get; set; }

    public string? RevalFinalresult { get; set; }

    public double? X { get; set; }

    public double? Sumoftotal { get; set; }

    public double? N { get; set; }

    public double? M { get; set; }

    public double? XminusM { get; set; }

    public double? SqOfXminusM { get; set; }

    public bool? IsAbsentThexternal { get; set; }

    public bool? IsAbsentPrexternal { get; set; }

    public double? Ft { get; set; }

    public double? Mm { get; set; }
}
