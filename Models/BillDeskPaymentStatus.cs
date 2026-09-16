using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskPaymentStatus
{
    public int StatusId { get; set; }

    public string? AuthStatus { get; set; }

    public string? Description { get; set; }
}
