using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstMarkSheetReport
{
    public int Id { get; set; }

    public int? ExamYearid { get; set; }

    public string? ExamYear { get; set; }

    public string? Semester { get; set; }

    public string? ReportPath { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDelete { get; set; }

    public string? MarksheetType { get; set; }

    public int? AssessmentId { get; set; }
}
