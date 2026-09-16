using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MasterPeriod
{
    public int Id { get; set; }

    public int? Sequence { get; set; }

    public string? PeriodTime { get; set; }

    public string? ClassLevel { get; set; }

    public string? Session { get; set; }

    public string? AcadYear { get; set; }
}
