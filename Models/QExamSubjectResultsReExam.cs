using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QExamSubjectResultsReExam
{
    public string? SubjectCode { get; set; }

    public string? SubjectName { get; set; }

    public byte? Credit { get; set; }

    public int? Appeard { get; set; }

    public int? PassCount { get; set; }

    public int? FailCount { get; set; }

    public decimal? PassPercentage { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamId { get; set; }
}
