using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstScheduleEvent
{
    public int ScheduleId { get; set; }

    public string? AcadYear { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly EventDate { get; set; }

    public string EventName { get; set; } = null!;

    public TimeOnly? FromTime { get; set; }

    public TimeOnly? ToTime { get; set; }

    public bool IsEmp { get; set; }

    public bool IsDelete { get; set; }

    public string? EventDesc { get; set; }

    public string? Color { get; set; }

    public bool? IsNotify { get; set; }

    public string? Email { get; set; }

    public TimeOnly? NotifyTime { get; set; }

    public bool? IsMailSent { get; set; }
}
