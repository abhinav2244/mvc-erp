using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TempFeePaid
{
    public int? Id { get; set; }

    public string? FeeHead { get; set; }

    public double? CashTotal { get; set; }

    public double? BankTotal { get; set; }

    public double? ChalTotal { get; set; }

    public double? TotalAmt { get; set; }

    public string? CourseLevel { get; set; }

    public string? FeeType { get; set; }
}
