using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QReExamResultFinal
{
    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? MotherName { get; set; }

    public string? CollegeCode { get; set; }

    public string? EnrollmentNumber { get; set; }

    public int? ExamFormId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public double? Total { get; set; }

    public double? MinimumMarks { get; set; }

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

    public double? NoColumnName { get; set; }

    public double? SumOfTotal { get; set; }

    public double? N { get; set; }

    public double? M { get; set; }

    public double? Xm { get; set; }

    public double? XM2 { get; set; }

    public bool? IsAbsentThexternal { get; set; }

    public bool? IsAbsentPrexternal { get; set; }

    public string? Ft { get; set; }

    public double? Mm { get; set; }

    public double? SumofXminusM { get; set; }

    public double? Sigma { get; set; }

    public double? Aa { get; set; }

    public double? Ab { get; set; }

    public double? Ba { get; set; }

    public double? Bb { get; set; }

    public double? Ca { get; set; }

    public double? Cb { get; set; }

    public double? Cc { get; set; }

    public string? Grade { get; set; }

    public double? CreditsTh { get; set; }

    public double? CreditsPr { get; set; }

    public double? CreditsForSub { get; set; }

    public double? SumOfCredits { get; set; }

    public double? CreditsPoints { get; set; }

    public string? Examname { get; set; }

    public double? ReExamMarks { get; set; }

    public string? CollegeName { get; set; }

    public int? FinalOutOf { get; set; }

    public double? SumofCreditspoint { get; set; }

    public int? TotalMarks { get; set; }

    public double? Sgpa { get; set; }

    public string? RptSubject { get; set; }

    public double? ReExamMarksReExam { get; set; }

    public double? ReExamMarksTheory { get; set; }

    public double? ReExamMarksPract { get; set; }

    public bool? IsReExamReExam { get; set; }

    public bool IsAbsentThreExam { get; set; }

    public bool IsAbsentPrreExam { get; set; }

    public double? ReExamMarksCalc { get; set; }

    public string ResultReExam { get; set; } = null!;

    public string FinalResultReExam { get; set; } = null!;

    public string? GradeReExam { get; set; }

    public double? CreditpointReExam { get; set; }

    public int? TotalMarksOne { get; set; }
}
