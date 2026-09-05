using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QRevaluationTr
{
    public string? Name { get; set; }

    public string? MotherName { get; set; }

    public string? Gender { get; set; }

    public string? CollegeCode { get; set; }

    public string? EnrollmentNumber { get; set; }

    public int? ExamFormId { get; set; }

    public int? ExamId { get; set; }

    public decimal? Total { get; set; }

    public decimal? MinimumMarks { get; set; }

    public string? SubjectType { get; set; }

    public decimal? FinalTotal { get; set; }

    public decimal? AppliedGrace { get; set; }

    public decimal? AppliedCondo { get; set; }

    public string? Abcd { get; set; }

    public string? Efgf { get; set; }

    public string? Result { get; set; }

    public string? FinalResult { get; set; }

    public string? OverallResult { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamSubjectId { get; set; }

    public string? RollNumber { get; set; }

    public decimal? ObtMarksThinternalMarks { get; set; }

    public decimal? ObtMarksThexternal { get; set; }

    public decimal? ObtMarksPrexternal { get; set; }

    public decimal? PracticalInternal { get; set; }

    public int? ExamSubjectId2 { get; set; }

    public string? SubjectCode { get; set; }

    public decimal? GraceCondMarks { get; set; }

    public decimal? CondMarksLessThan8 { get; set; }

    public decimal? CondMarksLessThan3 { get; set; }

    public decimal? X { get; set; }

    public decimal? M { get; set; }

    public decimal? XminusM { get; set; }

    public decimal? XminusMsquared { get; set; }

    public decimal? SumOfXminusMsquared { get; set; }

    public decimal? MaxmarksTotal { get; set; }

    public string? Aa { get; set; }

    public string? Ab { get; set; }

    public string? Ba { get; set; }

    public string? Bb { get; set; }

    public string? Ca { get; set; }

    public string? Cb { get; set; }

    public string? Cc { get; set; }

    public string? Grade { get; set; }

    public string? Condo { get; set; }

    public decimal? MarksReq { get; set; }

    public string? NotGraceSubject { get; set; }

    public string? ReqCondo { get; set; }

    public string? ReqGrace { get; set; }

    public decimal? OutofMarks { get; set; }

    public int? Apparred { get; set; }

    public int? Male { get; set; }

    public int? FeMale { get; set; }

    public int? PassCount { get; set; }

    public string? RptSubject { get; set; }

    public string? CollegeName { get; set; }

    public string? ExamName { get; set; }

    public bool? IsAbsentThExternal { get; set; }

    public bool? IsAbsentPrExternal { get; set; }

    public int? FinalOutOf { get; set; }

    public int? TotalMarks { get; set; }

    public double? ObtMarksThexternalReassessment { get; set; }

    public bool? IsReassessment { get; set; }

    public double? ReassessmentMarks { get; set; }

    public double? SubTotalMarks { get; set; }

    public int? TotalObtainedMarks { get; set; }

    public double? SubFinalTotalReassementMarks { get; set; }

    public double? OutOfmarksReassesment { get; set; }

    public string SubResult { get; set; } = null!;

    public string RevalFinalresult { get; set; } = null!;
}
