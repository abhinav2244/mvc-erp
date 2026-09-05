using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class SubjectTypeMaster
{
    public int TypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public string TypeAbr { get; set; } = null!;

    public int MaxSubCount { get; set; }

    public int TotalCredits { get; set; }

    public string ClassLevelId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public int BranchCode { get; set; }

    public string ClassSem { get; set; } = null!;

    public bool IsDelete { get; set; }

    public int? TotalSubCount { get; set; }
}
