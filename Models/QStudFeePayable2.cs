using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QStudFeePayable2
{
    public int StudId { get; set; }

    public string? StudAcadYear { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassLevel { get; set; }

    public string? StudClass { get; set; }

    public string? AdmnType { get; set; }

    public string? StudType { get; set; }

    public string? Expr1 { get; set; }

    public string? StudCommunityId { get; set; }

    public string? AdmnMode { get; set; }

    public double? FullAmount { get; set; }

    public double? StudFeePayable { get; set; }
}
