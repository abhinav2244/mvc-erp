using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class DetalisMeritList
{
    public int Id { get; set; }

    public int? MeritId { get; set; }

    public int? StudSrNo { get; set; }

    public string? StudentName { get; set; }

    public string? Gender { get; set; }

    public string? Category { get; set; }

    public string? PreviousClass { get; set; }

    public string? ObtainMarks { get; set; }

    public string? OutOfMarks { get; set; }

    public string? Percentage { get; set; }

    public DateTime? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public int? Extra3 { get; set; }

    public string? Extra4 { get; set; }

    public bool? IsDelete { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }
}
