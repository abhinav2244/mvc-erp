using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MdmsubjectSession
{
    public int SessionId { get; set; }

    public int SubjectCode { get; set; }

    public int? TotalSeats { get; set; }

    public int? FilledSeats { get; set; }

    public string? Status { get; set; }

    public bool? IsLocked { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? AllocatedCount { get; set; }

    public virtual ICollection<MdmsubjectAllowedBranch> MdmsubjectAllowedBranches { get; set; } = new List<MdmsubjectAllowedBranch>();

    public virtual MdmallocationSession Session { get; set; } = null!;
}
