using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QDailyFeesSummary1
{
    public string? CurrAcadYear { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? FeeName { get; set; }

    public int? FeeId { get; set; }

    public double? Amount { get; set; }

    public string? CashBank { get; set; }

    public string? BankPayDet { get; set; }

    public string? ClassLevel { get; set; }

    public short? RptBookNo { get; set; }

    public string? MaxOfRptNos { get; set; }

    public string? Cancelled { get; set; }

    public string? ShortName { get; set; }
}
