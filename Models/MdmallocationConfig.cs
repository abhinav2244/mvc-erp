using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MdmallocationConfig
{
    public int ConfigId { get; set; }

    public string ConfigName { get; set; } = null!;

    public string AcadYear { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool? IsOneTimeAllocation { get; set; }

    public bool? AllowUpgradation { get; set; }

    public int? MaxUpgradationRounds { get; set; }

    public string? BranchRestrictionType { get; set; }

    public bool? ShowLiveAvailability { get; set; }

    public decimal? SemesterWeight { get; set; }

    public decimal? Cetweight { get; set; }

    public string? AllocationAlgorithm { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual ICollection<MdmallocationSession> MdmallocationSessions { get; set; } = new List<MdmallocationSession>();
}
