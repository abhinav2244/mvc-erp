using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CatFeePercent
{
    public int? Id { get; set; }

    public int? FeeId { get; set; }

    public string? Category { get; set; }

    public double? GoiPercentage { get; set; }

    public double? ConPercentage { get; set; }
}
