using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QDailyCashCollection
{
    public short? RptBookNo { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? CashBank { get; set; }

    public string? ClassLevel { get; set; }

    public string? FeeName { get; set; }

    public double? Amount { get; set; }

    public string? SubAccount { get; set; }

    public int? StudId { get; set; }
}
