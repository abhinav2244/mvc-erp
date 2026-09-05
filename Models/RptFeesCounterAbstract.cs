using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class RptFeesCounterAbstract
{
    public int? RptBooNo { get; set; }

    public string? RptBookName { get; set; }

    public string? UserLogin { get; set; }

    public string? CounterNo { get; set; }

    public double? Cash { get; set; }

    public double? Bank { get; set; }

    public double? Chal { get; set; }

    public double? Total { get; set; }

    public int? Cancelled { get; set; }
}
