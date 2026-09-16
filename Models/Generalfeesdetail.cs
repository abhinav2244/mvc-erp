using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Generalfeesdetail
{
    public int? SrNo { get; set; }

    public int? FeesId { get; set; }

    public double? Amount { get; set; }

    public double? Balance { get; set; }

    public int? StudId { get; set; }

    public string? AcadYear { get; set; }

    public double? NetAmt { get; set; }
}
