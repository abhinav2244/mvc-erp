using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentPayable
{
    public int StudId { get; set; }

    public string? StudAcadyear { get; set; }

    public string? Studusername { get; set; }

    public string? StudEnrollNo { get; set; }

    public string? StudClass { get; set; }

    public int? SadBranchcode { get; set; }

    public string? CasteScholarship { get; set; }

    public string? Sadclasslevel { get; set; }

    public string? StudSection { get; set; }

    public string? StudCaste { get; set; }

    public string? StudCommunityId { get; set; }

    public string? BaseAcadYear { get; set; }

    public string? Sadadmtype { get; set; }

    public string? StudLocalPhone { get; set; }

    public string? SadAdmnMode { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? AdmnType { get; set; }

    public string? LocalOms { get; set; }

    public string? ClassLevel { get; set; }

    public string? Category { get; set; }

    public string? AdmnMode { get; set; }

    public double? FullPayable { get; set; }

    public double? StudPayable { get; set; }
}
