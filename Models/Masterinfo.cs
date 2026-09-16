using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Masterinfo
{
    public decimal Id { get; set; }

    public string? Department { get; set; }

    public string? Lroom { get; set; }

    public string? Lab { get; set; }

    public string? Batch { get; set; }

    public int? BranchCode { get; set; }
}
