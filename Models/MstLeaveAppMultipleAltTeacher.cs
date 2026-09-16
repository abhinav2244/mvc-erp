using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstLeaveAppMultipleAltTeacher
{
    public int Laid { get; set; }

    public int? AltTeacherId { get; set; }

    public int? LeaveAppId { get; set; }

    public DateOnly? LectureDate { get; set; }

    public TimeOnly? FromTime { get; set; }

    public TimeOnly? ToTime { get; set; }

    public bool? IsDelete { get; set; }

    public string? ClassId { get; set; }

    public int? SubjectCode { get; set; }

    public string? Section { get; set; }

    public string? Semester { get; set; }

    public bool? IsLeaveAccepted { get; set; }
}
