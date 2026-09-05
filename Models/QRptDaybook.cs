using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QRptDaybook
{
    public DateTime? VouDate { get; set; }

    public string? VouType { get; set; }

    public int? VouNo { get; set; }

    public string? DrCr { get; set; }

    public string? AccountName { get; set; }

    public double? Amount { get; set; }

    public string? Narration { get; set; }

    public int SrNo { get; set; }
}
