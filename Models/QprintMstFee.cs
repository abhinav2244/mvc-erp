using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QprintMstFee
{
    public string? Ftype { get; set; }

    public string? FeeName { get; set; }

    public string? ClassId { get; set; }

    public double? FullAmount { get; set; }

    public double? Goiamount { get; set; }

    public double? ConAmount { get; set; }

    public string? ShortName { get; set; }

    public int? ReceiptBookNo { get; set; }

    public string? FeeType { get; set; }

    public int? BranchCode { get; set; }

    public string? AdmnType { get; set; }

    public string? LocalOms { get; set; }

    public string? ClassLevel { get; set; }

    public string? AcadYear { get; set; }

    public string? Category { get; set; }

    public string? AdmnMode { get; set; }
}
