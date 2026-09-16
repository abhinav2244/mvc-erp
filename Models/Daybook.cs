using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Daybook
{
    public int DayBookId { get; set; }

    public string? VouType { get; set; }

    public int? VouNo { get; set; }

    public DateTime? VouDate { get; set; }

    public int? VentrySrNo { get; set; }

    public string? DrCr { get; set; }

    public string? AccountName { get; set; }

    public double? DrAmount { get; set; }

    public double? CrAmount { get; set; }

    public double? OpBal { get; set; }

    public double? ClBal { get; set; }

    public string? Narration { get; set; }

    public string? MainAcc { get; set; }

    public int SrNo { get; set; }

    public int? Sourceflag { get; set; }

    public string? DayBkCollegeCode { get; set; }
}
