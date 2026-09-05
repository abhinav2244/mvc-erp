using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TempFeeBalance
{
    public string? StudName { get; set; }

    public double? DevelopmentFee { get; set; }

    public double? UniExamFee { get; set; }

    public double? UniMiscFee { get; set; }

    public double? TuitionFee { get; set; }

    public double? Total { get; set; }

    public double? FeePayable { get; set; }

    public double? Balance { get; set; }
}
