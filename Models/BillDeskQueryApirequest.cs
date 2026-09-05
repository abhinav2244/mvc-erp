using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskQueryApirequest
{
    public int BdqarId { get; set; }

    public string? RequestType { get; set; }

    public string? MerchantId { get; set; }

    public string? TxncustomerId { get; set; }

    public string? CurrentDateTime { get; set; }

    public string? Checksum { get; set; }

    public DateTime? AppDateTime { get; set; }

    public bool? IsDelete { get; set; }
}
