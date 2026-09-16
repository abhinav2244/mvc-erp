using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QRptBookWiseBankWiseFeesCollection
{
    public string? CurrAcadYear { get; set; }

    public string? AcadYear { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public int RptBookNo { get; set; }

    public string? RptBookName { get; set; }

    public string? AccountNumber { get; set; }

    public string? BankName { get; set; }

    public double? Amount { get; set; }
}
