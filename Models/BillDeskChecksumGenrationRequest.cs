using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskChecksumGenrationRequest
{
    public int Chkgenreqid { get; set; }

    public int? Appid { get; set; }

    public string? Reqid { get; set; }

    public string? Pgmercid { get; set; }

    public int? Records { get; set; }

    public string? Pgcustomerid { get; set; }

    public decimal? Totaltxnamount { get; set; }

    public string? Txndate { get; set; }

    public string? Checksum { get; set; }

    public bool? IsValid { get; set; }

    public string? Status { get; set; }

    public bool? IsDelete { get; set; }
}
