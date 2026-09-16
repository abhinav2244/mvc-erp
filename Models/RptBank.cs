using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class RptBank
{
    public int? SrNo { get; set; }

    public DateTime? DateTr { get; set; }

    public double? SumCr { get; set; }

    public double? SumDr { get; set; }

    public double? OpCr { get; set; }

    public double? OpDr { get; set; }

    public double? ClCr { get; set; }

    public double? ClDr { get; set; }

    public string? ClassLevel { get; set; }
}
