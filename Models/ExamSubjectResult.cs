using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamSubjectResult
{
    public string? ExamSubjectId { get; set; }

    public int? PassCount { get; set; }

    public int? FailCount { get; set; }

    public double? PassPercentage { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamSubjectId1 { get; set; }

    public string? SubjectName { get; set; }

    public int? SubjectCredit { get; set; }
}
