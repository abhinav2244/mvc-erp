using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QBacklogTrResultPartOne
{
    public string? ResultReExam { get; set; }

    public string? Name { get; set; }

    public string? MotherName { get; set; }

    public string? Gender { get; set; }

    public string? CollegeCode { get; set; }

    public string? EnrollmentNumber { get; set; }

    public int? ExamFormId { get; set; }

    public int? ExamId { get; set; }

    public double? Total { get; set; }

    public double? MinimumMarks { get; set; }

    public string? SubjectType { get; set; }

    public double? FinalTotal { get; set; }

    public double? AppliedGrace { get; set; }

    public double? AppliedCondo { get; set; }

    public string? Result { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamSubjectId { get; set; }

    public string? RollNumber { get; set; }

    public double? IntTh { get; set; }

    public double? ObtMarksThexternal { get; set; }

    public string? SubjectCode { get; set; }

    public string? RptSubject { get; set; }

    public string? CollegeName { get; set; }

    public double? FinalOutOf { get; set; }

    public double? TotalMarks { get; set; }

    public string? ModeratedGrade { get; set; }

    public double? ReExamMarksCalc { get; set; }

    public string? FinalResultReExam { get; set; }

    public string? GradeReExam { get; set; }

    public string? BackAcadYear { get; set; }

    public double? CreditsForSub { get; set; }

    public int BackExamId { get; set; }

    public int BackFormId { get; set; }

    public int BackExamYearId { get; set; }

    public bool IsAbsentThextBack { get; set; }

    public bool IsAbsentPrExtBack { get; set; }

    public double? SumOfCredits { get; set; }

    public double? ObtMarksThinternalMarks { get; set; }

    public double? PracticalInternal { get; set; }

    public string? GradeInBacklog { get; set; }

    public double? BacPracExt { get; set; }

    public double? BackThext { get; set; }

    public double? BackMarks { get; set; }

    public decimal? Condo { get; set; }

    public int? ExamSubjectId2 { get; set; }

    public int? ExamSubjectId1 { get; set; }

    public double? CreditpointReExam { get; set; }

    public double? EarnedCreditPointsBacklog { get; set; }

    public int? AttemptId { get; set; }

    public int? BackDetId { get; set; }

    public int IsBacklog { get; set; }

    public int AppliedGraceInBacklog { get; set; }

    public double? AppliedCondoInBacklog { get; set; }

    public double? FinalBacklogCalc { get; set; }

    public string FinalResultBacklog { get; set; } = null!;

    public string? GradeBacklog { get; set; }

    public double? CreditpointBacklog { get; set; }

    public double? EarnedCreditPointsBacklognew { get; set; }

    public double? BacklogMarksTotal { get; set; }
}
