using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudfeesRpt
{
    public int? Id { get; set; }

    public string? Studid { get; set; }

    public string? StudClass { get; set; }

    public string? PaidAmount { get; set; }

    public string? GovernmentReceive { get; set; }

    public string? Balance { get; set; }

    public string? Refund { get; set; }

    public string? Category { get; set; }

    public string? Castescholarships { get; set; }
}
