using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class SubAcc
{
    public int SubAccId { get; set; }

    public string? AcNo { get; set; }

    public string? AcName { get; set; }

    public DateTime? AcDate { get; set; }

    public string? MainAccName { get; set; }

    public double? OpeningCr { get; set; }

    public double? OpeningDr { get; set; }

    public int? BugetProvision { get; set; }

    public string? Freeze { get; set; }

    public string? ClassLevel { get; set; }
}
