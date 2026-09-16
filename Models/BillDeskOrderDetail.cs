using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskOrderDetail
{
    public int OrderId { get; set; }

    public int? RegId { get; set; }

    public decimal? OrderAmount { get; set; }

    public decimal? HandlingCharges { get; set; }

    public decimal? TxnAmount { get; set; }

    public string? TxnId { get; set; }

    public string? TxnDate { get; set; }

    public string? PaymentDate { get; set; }

    public string? TxnReferenceNo { get; set; }

    public string? BankRefrenceNo { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? AuthStatus { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? IsDelete { get; set; }

    public string? FeesRelatedTo { get; set; }

    public int? FeesSrnoId { get; set; }

    public string? BilldeskTimestamp { get; set; }

    public string? BilldeskTraceid { get; set; }
}
