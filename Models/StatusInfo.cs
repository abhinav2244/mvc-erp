using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StatusInfo
{
    public int StatusId { get; set; }

    public string? StatusLoginId { get; set; }

    public DateTime? StatusLogDt { get; set; }

    public string? StatusYn { get; set; }
}
