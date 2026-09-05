using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class AssgMarksMaster
{
    public decimal Ano { get; set; }

    public string? FacultyId { get; set; }

    public decimal? AssgNo { get; set; }

    public int? DepartmentId { get; set; }

    public string? ClassLevel { get; set; }

    public string? Class { get; set; }

    public string? Semester { get; set; }

    public string? Subject { get; set; }

    public string? Section { get; set; }

    public string? AcademicYear { get; set; }

    public int? TotMrk { get; set; }

    public int? MinMrk { get; set; }

    public int? ExId { get; set; }
}
