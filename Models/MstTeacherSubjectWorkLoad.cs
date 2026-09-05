using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstTeacherSubjectWorkLoad
{
    public int Wlid { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public string? ClassLevel { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public int? SubjectCode { get; set; }

    public string? ThPrType { get; set; }

    public string? Section { get; set; }

    public double? WorkLoadHours { get; set; }

    public int? NoOfLectures { get; set; }
}
