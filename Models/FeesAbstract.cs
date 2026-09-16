using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class FeesAbstract
{
    public int? StudId { get; set; }

    public string? StudUserName { get; set; }

    public string? StudTitle { get; set; }

    public string? StudFirstName { get; set; }

    public string? StudMiddleName { get; set; }

    public string? StudMotherName { get; set; }

    public string? StudLastName { get; set; }

    public string? StudAcadYear { get; set; }

    public string? ClassLevel { get; set; }

    public int? BranchCode { get; set; }

    public string? StudClass { get; set; }

    public string? StudSection { get; set; }

    public string? AdmnType { get; set; }

    public string? StudCategory { get; set; }

    public int? RptBookNo { get; set; }

    public double? FeePayable { get; set; }

    public double? FeePaid { get; set; }

    public double? FeeBalance { get; set; }
}
