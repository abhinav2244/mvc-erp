using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstExam
{
    public int ExamId { get; set; }

    public string? ExamName { get; set; }

    public bool? IsSync { get; set; }

    public bool? IsActive { get; set; }

    public int? FacultId { get; set; }

    public string? ExamCode { get; set; }

    public int? MarksheetType { get; set; }

    public string? ClassLevel { get; set; }

    public int? BranchCode { get; set; }

    public string? Class { get; set; }

    public string? Semester { get; set; }

    public string? ExamYear { get; set; }

    public int? AssessmentId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool? HallticketPublish { get; set; }

    public bool? TimetablePublish { get; set; }

    public bool? IsReExamActive { get; set; }

    public bool? IsReAssessActive { get; set; }

    public bool? PrimaryDeclared { get; set; }

    public bool? FinalDeclared { get; set; }

    public int? PreExamId { get; set; }

    public int? AttemptId { get; set; }

    public bool? RevaluationDeclare { get; set; }

    public bool? BackDeclared { get; set; }

    public bool? BackRevalDeclared { get; set; }

    public bool? MarksheetPublish { get; set; }
}
