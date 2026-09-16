using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Resultinfo
{
    public int ResId { get; set; }

    public string? StudId { get; set; }

    public string? Class { get; set; }

    public string? Branch { get; set; }

    public string? Semester { get; set; }

    public string? StudName { get; set; }

    public string? EnrollmentNo { get; set; }

    public int? MarksObtain { get; set; }

    public int? TotalMarks { get; set; }

    public double? Percentage { get; set; }

    public int? HeadsPass { get; set; }

    public int? Totalheads { get; set; }

    public string? Session { get; set; }

    public string? Attempt { get; set; }

    public string? Result { get; set; }

    public string? Remarks { get; set; }

    public string? OverAllResult { get; set; }

    public int? MeritNo { get; set; }

    public string? ClassLevel { get; set; }

    public string? AcadYear { get; set; }

    public int? SrNo { get; set; }

    public string? UgJrHschCollege { get; set; }
}
