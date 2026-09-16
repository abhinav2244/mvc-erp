using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamExternalMarksEntry
{
    public int Emsid { get; set; }

    public int? MarksheetId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamFormId { get; set; }

    public int? ExamSubjectId { get; set; }

    public double? ObtMarksThexternal { get; set; }

    public double? ObtMarksPrexternal { get; set; }

    public bool? IsAbsentThexternal { get; set; }

    public bool? IsAbsentPrexternal { get; set; }

    public bool? UnFairMeanceThexternal { get; set; }

    public bool? UnFairMeancePrexternal { get; set; }

    public string? Remarks { get; set; }

    public int? InsentiveMarks { get; set; }

    public int? GraseMarks { get; set; }

    public int? CondonationMarks { get; set; }

    public string? Exemption { get; set; }

    public int? ControlSheetDetailsIdTh { get; set; }

    public int? ControlSheetDetailsIdPr { get; set; }

    public string? GradeTh { get; set; }

    public string? GradePointTh { get; set; }

    public string? GradeInt { get; set; }

    public int? GradePointInt { get; set; }

    public string? CondoThpr { get; set; }

    public int? GraceMarksPr { get; set; }

    public int? CondonationMarksPr { get; set; }

    public string? GraceThpr { get; set; }

    public bool? VarifyAbsentThext { get; set; }

    public bool? VarifyAbsentPrext { get; set; }

    public bool IsdeleteMs { get; set; }

    public bool? IsSubmit { get; set; }

    public bool? IsVerifyByCoe { get; set; }

    public double? ReassessmentMarks { get; set; }

    public bool? IsReassessment { get; set; }

    public bool? IsReassessmentSubmite { get; set; }

    public double? ReExamMarks { get; set; }

    public bool? IsReExam { get; set; }

    public bool? IsReExamSubmite { get; set; }

    public bool? VerifyAbsentThreExam { get; set; }

    public bool? IsAbsentThreExam { get; set; }

    public bool? VarifyAbsentPrreExam { get; set; }

    public bool? IsAbsentPrreExam { get; set; }

    public bool? IsVerifyByReExamCoe { get; set; }
}
