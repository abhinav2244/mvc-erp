using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Ttable
{
    public int Id { get; set; }

    public string? TeacherName { get; set; }

    public string? Days { get; set; }

    public string? Semester { get; set; }

    public string? Subject { get; set; }

    public string? ThorPr { get; set; }

    public string? Batch { get; set; }

    public string? Room { get; set; }

    public string? Period { get; set; }

    public string? Lab { get; set; }

    public string? Section { get; set; }

    public string? Acadyear { get; set; }

    public string? Departmentid { get; set; }

    public string? AcadSession { get; set; }

    public string? ClassLevel { get; set; }

    public int? PeriodNoDay { get; set; }

    public string? TabClassId { get; set; }

    public int? PerSequence { get; set; }
}
