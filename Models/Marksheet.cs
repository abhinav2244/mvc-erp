using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Marksheet
{
    public int MarksheetId { get; set; }

    public int? ExamFormId { get; set; }

    public int? TotalIncentiveMarks { get; set; }

    public int? IncentiveMarksNotUsed { get; set; }

    public int? TotalMaximumMarks { get; set; }

    public int? MarksObtained { get; set; }

    public string? Result { get; set; }

    public string? Remark { get; set; }

    public string? Division { get; set; }

    public decimal? TotalCredits { get; set; }

    public decimal? Sgpa { get; set; }

    public DateOnly? ResultDate { get; set; }

    public bool? IsWithheld { get; set; }

    public string? MarksheetRemark2 { get; set; }
}
