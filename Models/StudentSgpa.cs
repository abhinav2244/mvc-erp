using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentSgpa
{
    public int Id { get; set; }

    public int? Studid { get; set; }

    public string? ClassId { get; set; }

    public int? BranchCode { get; set; }

    public string? Semester { get; set; }

    public string? Session { get; set; }

    public string? AcadYear { get; set; }

    public double? Sgpa { get; set; }

    public double? Credits { get; set; }

    public double? TotalMarks { get; set; }

    public double? ObtainedMarks { get; set; }

    public string? EnrollmentNumber { get; set; }

    public string? Result { get; set; }

    public double? EarnedCredits { get; set; }
}
