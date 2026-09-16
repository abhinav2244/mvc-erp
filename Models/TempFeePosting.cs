using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TempFeePosting
{
    public int? SrNo { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? Particulars { get; set; }

    public string? Narration { get; set; }

    public double? Amount { get; set; }

    public string? SubAccount { get; set; }

    public string? MainAccount { get; set; }

    public int? SourceFlag { get; set; }

    public string? DayBkCollegeCode { get; set; }
}
