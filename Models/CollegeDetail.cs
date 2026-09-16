using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CollegeDetail
{
    public int ClgDetailsId { get; set; }

    public string? ClassLevel { get; set; }

    public short? DaysInWeek { get; set; }

    public short? TotalWeeks { get; set; }

    public short? TotalDaysAllWeeks { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public int? TimeInDay { get; set; }

    public int? TimeInWeek { get; set; }

    public int? TimeInAllWeeks { get; set; }

    public short? LectureTime { get; set; }

    public short? PracticalTime { get; set; }

    public short? BreakTime { get; set; }

    public short? TotalBreaks { get; set; }

    public short? BreakAfter { get; set; }
}
