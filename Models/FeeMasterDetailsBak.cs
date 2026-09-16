using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class FeeMasterDetailsBak
{
    public int? FeeId { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? AdmnType { get; set; }

    public string? LocalOms { get; set; }

    public string? ClassLevel { get; set; }

    public string? AcadYear { get; set; }

    public double? FullAmount { get; set; }

    public double? Goiamount { get; set; }

    public double? ConAmount { get; set; }

    public string? Category { get; set; }

    public string? AdmnMode { get; set; }
}
