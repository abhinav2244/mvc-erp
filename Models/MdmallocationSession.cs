using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MdmallocationSession
{
    public int SessionId { get; set; }

    public string? AcadYear { get; set; }

    public string? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public string? ClassLevel { get; set; }

    public int? BucketId { get; set; }

    public bool? IsCreated { get; set; }

    public bool? IsChoiceOpen { get; set; }

    public bool? IsLocked { get; set; }

    public bool? IsAllotmentDone { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LockedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ConfigId { get; set; }

    public int? AllocationRound { get; set; }

    public int? MaxRounds { get; set; }

    public bool? IsUpgradationRound { get; set; }

    public int? ParentSessionId { get; set; }

    public virtual MdmallocationConfig? Config { get; set; }

    public virtual ICollection<MdmallocationSession> InverseParentSession { get; set; } = new List<MdmallocationSession>();

    public virtual ICollection<MdmstudentMerit> MdmstudentMerits { get; set; } = new List<MdmstudentMerit>();

    public virtual ICollection<MdmsubjectSession> MdmsubjectSessions { get; set; } = new List<MdmsubjectSession>();

    public virtual MdmallocationSession? ParentSession { get; set; }
}
