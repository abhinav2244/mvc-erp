using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Mainacc
{
    public string? MainAccNo { get; set; }

    public string? AccName { get; set; }

    public DateTime? DateTr { get; set; }

    public string? UnderGroup { get; set; }

    public double? OpCr { get; set; }

    public double? OpDr { get; set; }

    public int? BugetProvision { get; set; }

    public string? Freeze { get; set; }

    public string? ClassLevel { get; set; }
}
