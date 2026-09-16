using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Rptincomeexpense
{
    public string? InParticulars { get; set; }

    public double? InAmount { get; set; }

    public string? ExParticulars { get; set; }

    public double? ExAmount { get; set; }
}
