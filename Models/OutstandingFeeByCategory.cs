using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class OutstandingFeeByCategory
{
    public int SrNo { get; set; }

    public double? TotalFee { get; set; }

    public string? Category { get; set; }

    public double? FeePaid { get; set; }

    public double? StudBalance { get; set; }

    public double? BalanceSwgovt { get; set; }

    public string? SchoolId { get; set; }
}
