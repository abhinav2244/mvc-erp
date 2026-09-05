using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Feedtlmst
{
    public int? FeeId { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? AdmnType { get; set; }

    public string? LocalOms { get; set; }

    public string? ClassLevel { get; set; }

    public string? AcadYear { get; set; }

    public float? FullAmount { get; set; }

    public float? Goiamount { get; set; }

    public float? ConAmount { get; set; }

    public string Category { get; set; } = null!;

    public string AdmnMode { get; set; } = null!;
}
