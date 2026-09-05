using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class RptDaybook
{
    public string? RecParticulars { get; set; }

    public float? RecAmount { get; set; }

    public string? PayParticulars { get; set; }

    public float? PayAmount { get; set; }

    public string? RecNarration { get; set; }

    public string? ClassLevel { get; set; }

    public DateTime? VouDate { get; set; }

    public string? PayNarration { get; set; }

    public string? RecVouNo { get; set; }

    public string? PayVouNo { get; set; }

    public int? SrNo { get; set; }
}
