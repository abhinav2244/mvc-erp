using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class LoanDetail
{
    public int? StudId { get; set; }

    public string? BankName { get; set; }

    public string? BankAddress { get; set; }

    public string? BankContactNo { get; set; }

    public string? AccNo { get; set; }

    public float? LoanAmt { get; set; }

    public float? AvailedAmt { get; set; }

    public float? InterestRate { get; set; }
}
