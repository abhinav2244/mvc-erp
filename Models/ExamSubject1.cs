using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamSubject1
{
    public int ExamSubjectId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public int? SubjectId { get; set; }

    public int? MaxMarksThinternal { get; set; }

    public int? MaxMarksThexternal { get; set; }

    public int? MaxMarksPrinternal { get; set; }

    public int? MaxMarksPrexternal { get; set; }

    public int? MinMarksThinternal { get; set; }

    public int? MinMarksThexternal { get; set; }

    public int? MinMarksPrinternal { get; set; }

    public int? MinMarksPrexternal { get; set; }

    public bool? IsSync { get; set; }

    public bool? IsActive { get; set; }

    public string? SubjectType { get; set; }

    public decimal? CreditsTh { get; set; }

    public decimal? CreditsPr { get; set; }

    public int? CreditsTot { get; set; }

    public int? TotalMarks { get; set; }

    public int? CreditsThint { get; set; }

    public int? CreditsPrint { get; set; }

    public bool? IsCsth { get; set; }

    public bool? IsCspr { get; set; }

    public bool? IsCsthint { get; set; }

    public bool? Iscsprint { get; set; }

    public int? MaxMarksTh2internal { get; set; }

    public int? MaxMarksTh2external { get; set; }

    public int? MinMarksTh2internal { get; set; }

    public int? MinMarksTh2external { get; set; }

    public string? CourseType { get; set; }

    public int? ExamDuration { get; set; }
}
