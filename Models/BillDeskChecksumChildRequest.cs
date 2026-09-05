using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskChecksumChildRequest
{
    public int Chkchildreqid { get; set; }

    public int? Chkgenreqid { get; set; }

    public int? Childrecordno { get; set; }

    public string? Mercid { get; set; }

    public decimal? Childamount { get; set; }

    public string? Customerid { get; set; }

    public string? Additionalinfo1 { get; set; }

    public string? Additionalinfo2 { get; set; }

    public string? Additionalinfo3 { get; set; }

    public string? Additionalinfo4 { get; set; }

    public string? Additionalinfo5 { get; set; }

    public string? Additionalinfo6 { get; set; }

    public string? Additionalinfo7 { get; set; }

    public string? Filler1 { get; set; }

    public string? Filler2 { get; set; }

    public string? Filler3 { get; set; }

    public bool? IsDelete { get; set; }
}
