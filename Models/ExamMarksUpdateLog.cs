using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamMarksUpdateLog
{
    public int UpdateId { get; set; }

    public int ExamId { get; set; }

    public int ExamFormId { get; set; }

    public int StudentId { get; set; }

    public int ExamSubjectId { get; set; }

    public string UpdatedExamType { get; set; } = null!;

    public string UpdatedColumnName { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public string? OriginalMarks { get; set; }

    public string? NewMarks { get; set; }

    public int? UpdatedBy { get; set; }

    public int? AssessmentId { get; set; }
}
