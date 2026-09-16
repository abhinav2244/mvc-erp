using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Receipthead
{
    public int HeadId { get; set; }

    public string? RecHead { get; set; }

    public string? ClassLevel { get; set; }

    public short? RptBookNo { get; set; }
}
