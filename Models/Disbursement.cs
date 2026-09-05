using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Disbursement
{
    public int? StudId { get; set; }

    public string? StudAcadYear { get; set; }

    public int? BranchCode { get; set; }

    public string? Ddno { get; set; }

    public DateTime? Dddate { get; set; }

    public string? ScholarshipOrderNo { get; set; }

    public double? MaintenanceAllowance { get; set; }

    public double? TuitionFees { get; set; }

    public double? ExamFees { get; set; }

    public double? OtherFees { get; set; }

    public double? TotalSanctioned { get; set; }

    public double? TuitionFeesDeduction { get; set; }

    public double? AmountPayable { get; set; }

    public double? Advance1 { get; set; }

    public double? Advance2 { get; set; }

    public double? Advance3 { get; set; }

    public double? Advance4 { get; set; }

    public int? OrderNo { get; set; }

    public string? ScholarshipType { get; set; }
}
