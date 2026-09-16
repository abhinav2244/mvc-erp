using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MdmstudentMerit
{
    public int MeritId { get; set; }

    public int SessionId { get; set; }

    public int StudentId { get; set; }

    public decimal SemesterScore { get; set; }

    public decimal? Cetscore { get; set; }

    public decimal TotalMerit { get; set; }

    public int MeritRank { get; set; }

    public string BranchCode { get; set; } = null!;

    public string? ClassLevel { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public int? BucketId { get; set; }

    public bool? IsEligible { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual MdmallocationSession Session { get; set; } = null!;
}
