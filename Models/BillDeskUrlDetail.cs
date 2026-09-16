using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskUrlDetail
{
    public int BdudId { get; set; }

    public string CustomerIdPrefix { get; set; } = null!;

    public string PaymentCallBackUrl { get; set; } = null!;

    public string? Flag { get; set; }

    public bool? IsDelete { get; set; }
}
