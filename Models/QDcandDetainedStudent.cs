using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QDcandDetainedStudent
{
    public string? Rollnumber { get; set; }

    public int? ExamId { get; set; }

    public int ExamFormId { get; set; }

    public int? ExamYearId { get; set; }

    public string? StudStatus { get; set; }

    public double? AttendFine { get; set; }

    public int DontShow { get; set; }
}
