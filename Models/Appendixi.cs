using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Appendixi
{
    public string? Class { get; set; }

    public int? NoOfMcard { get; set; }

    public int? From { get; set; }

    public int? To { get; set; }

    public int? DepositAmt { get; set; }

    public string? RptNo { get; set; }

    public DateTime? RptDate { get; set; }

    public string? AcadYear { get; set; }
}
