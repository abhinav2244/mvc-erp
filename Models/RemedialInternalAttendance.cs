using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class RemedialInternalAttendance
{
    public int Simid { get; set; }

    public string? ClasId { get; set; }

    public string? Semester { get; set; }

    public int? BranchCode { get; set; }

    public int? SubjectCode { get; set; }

    public string? SubjectType { get; set; }

    public int? StudId { get; set; }

    public double? Assignment1 { get; set; }

    public double? Assignment2 { get; set; }

    public double? Mse1 { get; set; }

    public double? Mse2 { get; set; }

    public double? Mse3 { get; set; }

    public double? PracticalInternal { get; set; }

    public double? Assignment3 { get; set; }

    public double? Mse4 { get; set; }

    public double? Mse5 { get; set; }

    public bool? IsSubmit { get; set; }

    public string? Remark { get; set; }

    public bool? IsMse1absent { get; set; }

    public bool? IsMse2absent { get; set; }

    public bool? IsMse3absent { get; set; }

    public bool? IsPracticalAbsent { get; set; }

    public bool? Assignment1Submit { get; set; }

    public bool? Assignment2Submit { get; set; }

    public bool? Mse1Submit { get; set; }

    public bool? Mse2Submit { get; set; }

    public bool? Mse3Submit { get; set; }

    public bool? PracticalInternalSubmit { get; set; }

    public int? PreSimid { get; set; }
}
