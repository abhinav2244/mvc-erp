using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Concessionapproved
{
    public int? StudId { get; set; }

    public string? StudAcadYear { get; set; }

    public string? Concession { get; set; }

    public DateTime? ConcessionApplDate { get; set; }

    public double? FeeHead1 { get; set; }

    public double? FeeHead2 { get; set; }

    public double? FeeHead3 { get; set; }

    public double? FeeHead4 { get; set; }

    public double? FeeHead5 { get; set; }

    public double? FeeHead6 { get; set; }

    public double? FeeHead7 { get; set; }

    public double? FeeHead8 { get; set; }

    public double? TotalFee { get; set; }

    public double? IrregularAttendanceCut { get; set; }

    public double? TotalPayable { get; set; }

    public short? AttendanceQtr1 { get; set; }

    public short? AttendanceQtr2 { get; set; }

    public short? AttendanceQtr3 { get; set; }

    public short? AttendanceQtr4 { get; set; }

    public string? StudRuralUrban { get; set; }

    public short? SchoolDaysQtr1 { get; set; }

    public short? SchoolDaysQtr2 { get; set; }

    public short? SchoolDaysQtr3 { get; set; }

    public short? SchoolDaysQtr4 { get; set; }

    public string? Remarks { get; set; }

    public string? Narration1 { get; set; }

    public string? Narration2 { get; set; }

    public string? ConcessionStatus { get; set; }

    public short? BranchCode { get; set; }

    public string? IncomeCertificate { get; set; }

    public double? ParentAnnualIncome { get; set; }

    public string? MiddleSchoolCert { get; set; }
}
