using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QStudAllFeesDetail
{
    public int StudId { get; set; }

    public string? StudRemarks { get; set; }

    public string? StudFirstName { get; set; }

    public string? StudMiddleName { get; set; }

    public string? StudLastName { get; set; }

    public string? StudAcadYear { get; set; }

    public string? ClassLevel { get; set; }

    public string? StudClass { get; set; }

    public int? BranchCode { get; set; }

    public string? StudSection { get; set; }

    public string? Category { get; set; }

    public string? AdmnType { get; set; }

    public double? FeePayable1 { get; set; }

    public double? FeePaid1 { get; set; }

    public double? FeeBalance1 { get; set; }

    public double? FeePayable2 { get; set; }

    public double? FeePaid2 { get; set; }

    public double? FeeBalance2 { get; set; }

    public double? FeePayable3 { get; set; }

    public double? FeePaid3 { get; set; }

    public double? FeeBalance3 { get; set; }

    public double? FeePayable4 { get; set; }

    public double? FeePaid4 { get; set; }

    public double? FeeBalance4 { get; set; }
}
