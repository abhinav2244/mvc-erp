using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskPaymentResponse
{
    public int Payrespid { get; set; }

    public int? Chkgenreqid { get; set; }

    public string? Pgmercid { get; set; }

    public string? Pgcustomerid { get; set; }

    public string? TxnReferenceNo { get; set; }

    public string? BankReferenceNo { get; set; }

    public decimal? TxnAmount { get; set; }

    public string? BankId { get; set; }

    public string? Filler1 { get; set; }

    public string? TxnType { get; set; }

    public string? CurrencyType { get; set; }

    public string? ItemCode { get; set; }

    public string? Filler2 { get; set; }

    public string? Filler3 { get; set; }

    public string? Filler4 { get; set; }

    public string? TxnDate { get; set; }

    public string? AuthStatus { get; set; }

    public string? Filler5 { get; set; }

    public string? Email { get; set; }

    public string? MobileNo { get; set; }

    public string? AdditionalInfo3 { get; set; }

    public string? AdditionalInfo4 { get; set; }

    public string? AdditionalInfo5 { get; set; }

    public string? AdditionalInfo6 { get; set; }

    public string? AdditionalInfo7 { get; set; }

    public string? ErrorStatus { get; set; }

    public string? ErrorDescription { get; set; }

    public string? Checksum { get; set; }

    public bool? IsDelete { get; set; }
}
