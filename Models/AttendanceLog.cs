using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class AttendanceLog
{
    public int AttendanceLogId { get; set; }

    public DateTime AttendanceDate { get; set; }

    public int EmployeeId { get; set; }

    public string? InTime { get; set; }

    public string? InDeviceId { get; set; }

    public string? OutTime { get; set; }

    public string? OutDeviceId { get; set; }

    public double Duration { get; set; }

    public int LateBy { get; set; }

    public int EarlyBy { get; set; }

    public int IsOnLeave { get; set; }

    public string? LeaveType { get; set; }

    public double? LeaveDuration { get; set; }

    public int WeeklyOff { get; set; }

    public int Holiday { get; set; }

    public string? LeaveRemarks { get; set; }

    public string PunchRecords { get; set; } = null!;

    public int ShiftId { get; set; }

    public double Present { get; set; }

    public double Absent { get; set; }

    public string Status { get; set; } = null!;

    public string StatusCode { get; set; } = null!;

    public string? P1status { get; set; }

    public string? P2status { get; set; }

    public string? P3status { get; set; }

    public int IsonSpecialOff { get; set; }

    public string? SpecialOffType { get; set; }

    public string? SpecialOffRemark { get; set; }

    public int? SpecialOffDuration { get; set; }

    public int OverTime { get; set; }

    public int OverTimeE { get; set; }

    public int MissedOutPunch { get; set; }

    public string? Remarks { get; set; }

    public int? MissedInPunch { get; set; }

    public string? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public string? C4 { get; set; }

    public string? C5 { get; set; }

    public string? C6 { get; set; }

    public string? C7 { get; set; }

    public int? LeaveTypeId { get; set; }

    public int? LossOfHours { get; set; }
}
