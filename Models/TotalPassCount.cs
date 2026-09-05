using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TotalPassCount
{
    public int? TotalPassCount1 { get; set; }

    public int? TotalFailCount { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }
}
