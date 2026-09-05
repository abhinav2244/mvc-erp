using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QExRptdailycollRegister
{
    public string? CounterNo { get; set; }

    public string? StudAcadYear { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public int? FeesReceiptNo { get; set; }

    public int? StudId { get; set; }

    public string? Studname { get; set; }

    public string? Feetype { get; set; }

    public string? StudClass { get; set; }

    public double? PaidAmt { get; set; }

    public string? Cancelled { get; set; }

    public string? Cashbank { get; set; }

    public int? SrNo { get; set; }

    public string? Classlevel { get; set; }

    public string? RptBookName { get; set; }

    public string? ClassLevelno { get; set; }

    public short? RptBookNo { get; set; }

    public string? SchoolId { get; set; }

    public string? TrustName { get; set; }

    public string? Address1 { get; set; }
}
