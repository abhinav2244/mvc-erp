using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Schadvancedetail
{
    public int? OrderSrNo { get; set; }

    public double? TotalSanctioned { get; set; }

    public double? TuitionFees { get; set; }

    public double? ExaminationFees { get; set; }

    public double? OtherFees { get; set; }

    public int? StudGrno { get; set; }

    public string? ClassLevel { get; set; }

    public string? PaidTag { get; set; }

    public int? StudId { get; set; }

    public string? StudAcadYear { get; set; }
}
