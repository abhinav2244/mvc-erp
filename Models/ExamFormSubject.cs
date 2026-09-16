using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamFormSubject
{
    public int ExamFormSubjectId { get; set; }

    public int? ExamFormId { get; set; }

    public int? ExamSubjectId { get; set; }

    public int? ObtainedMarksThinternal { get; set; }

    public int? ObtainedMarksThexternal { get; set; }

    public int? ObtainedMarksPrinternal { get; set; }

    public int? ObtainedMarksPrexternal { get; set; }

    public int? InsentiveMarks { get; set; }

    public int? GraseMarks { get; set; }

    public int? CondonationMarks { get; set; }

    public string? Exemption { get; set; }

    public bool? Isdelete { get; set; }

    public bool? IsReassessment { get; set; }

    public bool? IsReExam { get; set; }
}
