using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Qfeedback
{
    public int? TeacherName { get; set; }

    public string? Subject { get; set; }

    public string? DepartmentName { get; set; }

    public decimal? SumOfTotal { get; set; }

    public int? CountOfTotal { get; set; }

    public decimal? Pindex { get; set; }

    public string Remarks { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public string? Initials { get; set; }

    public int? EmpDesignationId { get; set; }

    public string? AcadYear { get; set; }

    public string? AcadSession { get; set; }
}
