using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CancelledReceiptDatum
{
    public int CreceiptId { get; set; }

    public int StudentId { get; set; }

    public int ReceiptNo { get; set; }

    public double? ReceiptAmount { get; set; }

    public string? PaymentMode { get; set; }

    public string Cancelled { get; set; } = null!;

    public DateTime? CancelledDate { get; set; }

    public string CounterNo { get; set; } = null!;

    public string? ReceiptCancelledRemarks { get; set; }

    public int? SrNo { get; set; }
}
