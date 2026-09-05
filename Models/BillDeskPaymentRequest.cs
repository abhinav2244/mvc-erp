using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskPaymentRequest
{
    public int PayReqRid { get; set; }

    public int? Chkgenreqid { get; set; }

    public string? PgmerchantId { get; set; }

    public string? PgcustomerId { get; set; }

    public string? Filler1 { get; set; }

    public string? TxnAmount { get; set; }

    public string? BankId { get; set; }

    public string? Filler2 { get; set; }

    public string? Filler3 { get; set; }

    public string? CurrencyType { get; set; }

    public string? ItemCode { get; set; }

    public string? TypeField1 { get; set; }

    public string? SecurityId { get; set; }

    public string? Filler4 { get; set; }

    public string? Filler5 { get; set; }

    public string? TypeField2 { get; set; }

    public string? AdditionalInfo1 { get; set; }

    public string? AdditionalInfo2 { get; set; }

    public string? AdditionalInfo3 { get; set; }

    public string? AdditionalInfo4 { get; set; }

    public string? AdditionalInfo5 { get; set; }

    public string? AdditionalInfo6 { get; set; }

    public string? AdditionalInfo7 { get; set; }

    public string? AdditionalInfo8 { get; set; }

    public string? Checksum { get; set; }

    public bool? IsDelete { get; set; }
}
