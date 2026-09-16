using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class WeeklyAttendanceRemark
{
    public int RemarkId { get; set; }

    public DateOnly? AttendanceDate { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public int? BranchCode { get; set; }

    public string? TimeSlot { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedOn { get; set; }
}
