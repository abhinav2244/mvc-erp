using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MseexamTimetable
{
    public int ExamId { get; set; }

    public DateOnly ExamDate { get; set; }

    public TimeOnly? ExamFromTime { get; set; }

    public TimeOnly? ExamToTime { get; set; }

    public string? DayId { get; set; }

    public string? ClassLevel { get; set; }

    public string Branch { get; set; } = null!;

    public string Class { get; set; } = null!;

    public string Semester { get; set; } = null!;

    public string? Section { get; set; }

    public string SubjectCode { get; set; } = null!;

    public int? InternalTypeId { get; set; }

    public bool? IsDelete { get; set; }
}
