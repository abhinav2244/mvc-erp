using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Delmelog
{
    public decimal FulId { get; set; }

    public int? SrNo { get; set; }

    public string? UserLogin { get; set; }

    public string? UserInfo { get; set; }

    public string? CounterNo { get; set; }

    public int? FeesReceiptNo { get; set; }
}
