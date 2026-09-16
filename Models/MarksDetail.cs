using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MarksDetail
{
    public int? StudId { get; set; }

    public string? Class { get; set; }

    public string? Branch { get; set; }

    public string? Semester { get; set; }

    public int? MarksObtain { get; set; }

    public int? TotalMarks { get; set; }

    public double? Percentage { get; set; }

    public string? ClassLevel { get; set; }

    public string? AcadYear { get; set; }

    public string? StudUserName { get; set; }

    public string? UniBoard { get; set; }

    public string? RollNo { get; set; }

    public string? Sgpa { get; set; }

    public string? Rsession { get; set; }

    public string? Result { get; set; }

    public string? Cgpa { get; set; }
}
