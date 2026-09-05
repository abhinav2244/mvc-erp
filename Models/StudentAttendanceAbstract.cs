using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentAttendanceAbstract
{
    public decimal SaaId { get; set; }

    public int? StudId { get; set; }

    public string? SubjectCode { get; set; }

    public string? AcademicYearId { get; set; }

    public double? AttPercent { get; set; }
}
