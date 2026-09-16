using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentAttendanceNotice
{
    public decimal StudentAttMsgCode { get; set; }

    public decimal? StudentAttendanceCode { get; set; }

    public string? StudentAbsentId { get; set; }

    public string? AttendanceMsg { get; set; }
}
