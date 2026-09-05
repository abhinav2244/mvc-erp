using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class AcdActivityPlanBatchWise
{
    public int BId { get; set; }

    public int? CId { get; set; }

    public string? Batch { get; set; }

    public DateTime? PlanedDt { get; set; }

    public DateTime? ComplDt { get; set; }

    public string? Remark { get; set; }
}
