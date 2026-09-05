using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TimeTablePrintTemp
{
    public string? PrintSessionId { get; set; }

    public string? DayName { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public string? SubjectName { get; set; }

    public string? ThPrType { get; set; }

    public string? RoomName { get; set; }

    public string? Batch { get; set; }

    public DateTime? CreatedDate { get; set; }
}
