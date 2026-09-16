using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Receiptno
{
    public short RptBookNo { get; set; }

    public int? OpeningRptNo { get; set; }

    public string ClassLevel { get; set; } = null!;
}
