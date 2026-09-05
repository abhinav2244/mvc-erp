using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class VwStudentAttendance
{
    public string? AcadYear { get; set; }

    public string? AcademicSession { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public int? SubjectCode { get; set; }

    public string? ThPrtype { get; set; }

    public int? EmployeeId { get; set; }

    public int? StudId { get; set; }

    public string? ModifiedStatus { get; set; }

    public DateOnly? AttendanceDate { get; set; }
}
