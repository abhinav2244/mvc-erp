using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Trutidetail
{
    public int? StudId { get; set; }

    public string? StudAcadYear { get; set; }

    public int? BranchCode { get; set; }

    public string? TrutiStatus { get; set; }

    public string? Reason1 { get; set; }

    public string? Reason2 { get; set; }

    public string? Reason3 { get; set; }

    public string? Reason4 { get; set; }

    public string? Reason5 { get; set; }

    public string? Reason6 { get; set; }

    public string? BillNo { get; set; }

    public string? OrderNo { get; set; }

    public DateTime? Date { get; set; }

    public int? GrossAmount { get; set; }

    public string? Plan { get; set; }

    public string? Remarks { get; set; }
}
