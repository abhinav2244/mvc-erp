using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Maintperiod
{
    public int? Id { get; set; }

    public string? ClassLevel { get; set; }

    public string? ClassAbbr { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public int? MonthDiff { get; set; }
}
