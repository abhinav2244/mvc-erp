using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QStudFeePaid
{
    public int? StudId { get; set; }

    public int SrNo { get; set; }

    public int? FeesReceiptNo { get; set; }

    public string? CashBank { get; set; }

    public string? BankName { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ChqDddate { get; set; }

    public double? ChqDdamt { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? Cancelled { get; set; }

    public short? ReceiptBookNo { get; set; }

    public string? CurrAcadYear { get; set; }

    public string? AcadYear { get; set; }

    public string? Flag { get; set; }

    public string? ClassLevel { get; set; }

    public string? RefundNote { get; set; }

    public string? Remark { get; set; }

    public int? FeeId { get; set; }

    public double? FeePayable { get; set; }

    public double? FeePaid { get; set; }

    public double? Balance { get; set; }
}
