using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QTotalpassfailcount
{
    public int? Appeard { get; set; }

    public int? TotalPassCount { get; set; }

    public int? TotalFailCount { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }
}
