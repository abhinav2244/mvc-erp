using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QMinMaxRptNo
{
    public string? ClassLevel { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public short? RptBookNo { get; set; }

    public string? CashBank { get; set; }

    public string? Cancelled { get; set; }

    public string? RptNos { get; set; }
}
