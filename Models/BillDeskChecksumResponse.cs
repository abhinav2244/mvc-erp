using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskChecksumResponse
{
    public int Chkreqrespid { get; set; }

    public int? Chkgenreqid { get; set; }

    public string? Pgmercid { get; set; }

    public string? Pgcustomerid { get; set; }

    public int? Records { get; set; }

    public decimal? Totaltxnamount { get; set; }

    public int? Statuscode { get; set; }

    public string? Statusdesc { get; set; }

    public string? Filler1 { get; set; }

    public string? Filler2 { get; set; }

    public string? Filler3 { get; set; }

    public string? Customerid1 { get; set; }

    public string? Ecomtxnid1 { get; set; }

    public string? Customerid2 { get; set; }

    public string? Ecomtxnid2 { get; set; }

    public string? Customerid3 { get; set; }

    public string? Ecomtxnid3 { get; set; }

    public string? Checksum { get; set; }

    public bool? IsValid { get; set; }

    public string? ValidationStatus { get; set; }

    public bool? IsDelete { get; set; }
}
