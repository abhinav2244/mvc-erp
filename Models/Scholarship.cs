using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Scholarship
{
    public int? StudId { get; set; }

    public string? StudAcadYear { get; set; }

    public double? SanctionedAmount { get; set; }

    public string? SanctionedforDuration { get; set; }

    public string? Hosteller { get; set; }

    public DateTime? HostelAllocationDate { get; set; }

    public double? ParentAnnualIncome { get; set; }

    public string? PeriodofMaintenance { get; set; }

    public string? SchOrderNo { get; set; }

    public double? MaintenanceAllowance { get; set; }

    public double? TuitionFees { get; set; }

    public double? ExaminationFees { get; set; }

    public double? PracticalFees { get; set; }

    public double? OtherFees { get; set; }

    public double? TotalSanctioned { get; set; }

    public string? Sanctioned { get; set; }

    public string? Remarks { get; set; }

    public string? ScholarshipType { get; set; }

    public string? LastExam1 { get; set; }

    public string? LastExam2 { get; set; }

    public string? LastExam3 { get; set; }

    public string? CreamyLayerCertificate { get; set; }

    public string? DeathCertificate { get; set; }

    public string? PractSubjects { get; set; }

    public string? ScholarshipStatus { get; set; }

    public string? HostelType { get; set; }

    public int? OrderNo { get; set; }

    public string? TrutiStatus { get; set; }

    public string? BankName { get; set; }

    public string? Branch { get; set; }

    public string? AccountNo { get; set; }

    public string? Ifsc { get; set; }

    public string? Micr { get; set; }

    public string? BankBranchName { get; set; }
}
