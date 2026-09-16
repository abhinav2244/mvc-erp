using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Receiptbook
{
    public int RptBookNo { get; set; }

    public string? RptBookName { get; set; }

    public string? Accountable { get; set; }

    public int? OpeningRptNo { get; set; }
}
