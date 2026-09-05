using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TempFeesSch
{
    public int SrNo { get; set; }

    public int? Studid { get; set; }

    public string? Name { get; set; }

    public string? PrnNo { get; set; }

    public string? ContactNo { get; set; }

    public double? FeesAdmin { get; set; }

    public string? Category { get; set; }

    public double? FeesCurr { get; set; }

    public double? FeesPayable { get; set; }

    public double? FeesReceivable { get; set; }

    public double? FeesPaid { get; set; }

    public double? FeesReceived { get; set; }

    public double? StudBalance { get; set; }

    public double? BalanceSwgovt { get; set; }

    public string? CasteScholarship { get; set; }

    public string? AdmnType { get; set; }

    public string? SchoolId { get; set; }
}
