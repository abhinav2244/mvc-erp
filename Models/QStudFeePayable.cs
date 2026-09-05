using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QStudFeePayable
{
    public int StudId { get; set; }

    public string? CategoryId { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? AdmnType { get; set; }

    public string? StudType { get; set; }

    public string? ClassLevel { get; set; }

    public string? AcadYear { get; set; }

    public string? AdmnMode { get; set; }

    public string? ScholarshipType { get; set; }

    public int? ReceiptBookNo { get; set; }

    public int? FeeId { get; set; }

    public double? FeePayable { get; set; }

    public double? FullPayable { get; set; }

    public double? Goiamount { get; set; }

    public double? ConAmount { get; set; }

    public string? FeeName { get; set; }

    public string? FeeType { get; set; }

    public string? ShortName { get; set; }
}
