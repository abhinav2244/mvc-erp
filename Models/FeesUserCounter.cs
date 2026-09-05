using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class FeesUserCounter
{
    public decimal? FucId { get; set; }

    public string? UserLogin { get; set; }

    public string? CounterNo { get; set; }

    public int? LoginId { get; set; }

    public string? Rpt { get; set; }

    public string? Usb { get; set; }
}
