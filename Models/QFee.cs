using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QFee
{
    public int? FeesId { get; set; }

    public string? FeeDescription { get; set; }

    public int? StudAdmnFormNo { get; set; }

    public string? StudStatus { get; set; }

    public string? AdmnStatus { get; set; }

    public string? StudUserName { get; set; }

    public int? FeesReceiptNo { get; set; }

    public double? Amount { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? SchoolId { get; set; }

    public short? RptBookNo { get; set; }

    public string? BranchName { get; set; }

    public string? ConSch { get; set; }

    public string? ClassLevel { get; set; }

    public string? AdmType { get; set; }

    public string? CashBank { get; set; }

    public int? StudGrno { get; set; }

    public string? Category { get; set; }

    public string? AmountInWords { get; set; }

    public double? PaidAmt { get; set; }

    public string? ClassId { get; set; }

    public string? BankAcNo { get; set; }

    public string? StudSemester { get; set; }

    public string? FeeType { get; set; }

    public string? Title { get; set; }

    public string? Name { get; set; }

    public string? BankName { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ChqDddate { get; set; }

    public double? NetAmt { get; set; }

    public string? Cancelled { get; set; }

    public string? AcadYear { get; set; }

    public string? CurrAcadYear { get; set; }

    public string? Flag { get; set; }

    public double? FeePayable { get; set; }

    public double? Balance { get; set; }

    public double? OptFees { get; set; }

    public double? OptFeePaid { get; set; }

    public double? FeePaid { get; set; }

    public string? BaseAcadYear { get; set; }

    public string? UserStudId { get; set; }

    public int? StudId { get; set; }

    public string? FeeTypeName { get; set; }

    public string? Remark { get; set; }

    public string? RptNos { get; set; }

    public double? ChqDdamt { get; set; }

    public int SrNo { get; set; }

    public double? AmountRefund { get; set; }

    public string? StudEnrollNo { get; set; }

    public string? ShortName { get; set; }

    public double? FeeNetAmt { get; set; }

    public string? Hidden { get; set; }

    public string? Used { get; set; }
}
