using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BankMaster
{
    public int BankId { get; set; }

    public string? AccountNumber { get; set; }

    public string? BankName { get; set; }

    public string? City { get; set; }
}
