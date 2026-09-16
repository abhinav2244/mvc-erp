using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MsMlclecture
{
    public int Elid { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public int? SubjectCode { get; set; }

    public string? ThPrtype { get; set; }

    public int? BatchId { get; set; }

    public int? RoomId { get; set; }

    public DateOnly? LectureDate { get; set; }

    public TimeOnly? FromTime { get; set; }

    public TimeOnly? ToTime { get; set; }

    public short? AttendanceDay { get; set; }

    public short? AttendanceMonth { get; set; }

    public string? AcademicSession { get; set; }

    public string? TopicCoverd { get; set; }

    public int? TopicId { get; set; }

    public string? AttendanceRemarkId { get; set; }

    public string? Remark { get; set; }

    public string LectureType { get; set; } = null!;

    public int? TakeOverEmpId { get; set; }

    public int? BranchCode { get; set; }

    public string? AttendanceClassPhoto { get; set; }

    public string? SubjectName { get; set; }
}
