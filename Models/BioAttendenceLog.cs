using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BioAttendenceLog
{
    public int AttendenceLogId { get; set; }

    public DateTime AttendenceDate { get; set; }

    public int EmployeeId { get; set; }

    public string InTime { get; set; } = null!;

    public string InDeviceId { get; set; } = null!;

    public string OutTime { get; set; } = null!;

    public string OutDeviceId { get; set; } = null!;

    public int Duration { get; set; }

    public int LateBy { get; set; }

    public int EarlyBy { get; set; }

    public string IsOneLeave { get; set; } = null!;

    public string LeaveType { get; set; } = null!;

    public int LeaveDuration { get; set; }
}
