using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Feesmaster
{
    public int FeeId { get; set; }

    public string? FeeName { get; set; }

    public string? ShortName { get; set; }

    public int? ReceiptBookNo { get; set; }

    public string? BankAc { get; set; }

    public string? MainAc { get; set; }

    public string? FeeType { get; set; }

    public string? Hidden { get; set; }

    public string? ClassLevel { get; set; }

    public string? AcadYear { get; set; }

    public string? Used { get; set; }

    public string? SubAccount { get; set; }
}
