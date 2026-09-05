using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class OutstandingFee
{
    public int SrNo { get; set; }

    public string? Name { get; set; }

    public string? PrnNo { get; set; }

    public double? TotalFee { get; set; }

    public string? Category { get; set; }

    public double? FeePaid { get; set; }

    public double? StudBalance { get; set; }

    public double? BalanceSwgovt { get; set; }

    public string? SchoolId { get; set; }
}
