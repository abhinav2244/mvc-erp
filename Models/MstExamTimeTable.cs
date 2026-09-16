using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstExamTimeTable
{
    public int Etid { get; set; }

    public int? ExamSubjectId { get; set; }

    public int? ExamId { get; set; }

    public DateOnly? ExamDate { get; set; }

    public string? DayId { get; set; }

    public TimeOnly? ExamFromTime { get; set; }

    public TimeOnly? ExamToTime { get; set; }

    public string? Remark { get; set; }

    public bool? IsDelete { get; set; }

    public int? ExamYearId { get; set; }
}
