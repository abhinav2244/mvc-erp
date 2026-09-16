using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Prospectussell
{
    public string? CurrAcadYear { get; set; }

    public string? ClassLevel { get; set; }

    public string? Class { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public int? ReceiptNo { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? FeeHead { get; set; }

    public double? Amount { get; set; }

    public string? Cancelled { get; set; }

    public string? AppFormNo { get; set; }

    public int ProspId { get; set; }

    public string? StikerNo { get; set; }

    public int? Regid { get; set; }

    public int? Studid { get; set; }

    public string? Trnno { get; set; }

    public int? Orderid { get; set; }

    public string? Mobileno { get; set; }

    public string? Emailid { get; set; }

    public string? Flag { get; set; }
}
