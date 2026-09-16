using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ZUserLogDetail
{
    public int LogId { get; set; }

    public int? UserId { get; set; }

    public string? LogDetails { get; set; }

    public DateTime? LogDateTime { get; set; }
}
