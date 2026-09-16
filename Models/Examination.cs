using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Examination
{
    public int SrNo { get; set; }

    public int? Studid { get; set; }

    public int? BranchCode { get; set; }

    public int? MarksObtained { get; set; }

    public int? TotalMarks { get; set; }

    public double? Percentage { get; set; }

    public int? HeadsPass { get; set; }

    public int? TotalHead { get; set; }

    public string? AcadYear { get; set; }

    public string? AcadSession { get; set; }

    public string? Semester { get; set; }

    public string? Attempts { get; set; }

    public string? Result { get; set; }

    public string? Classlevel { get; set; }

    public string? Remarks { get; set; }
}
