using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MdmBucketTrack
{
    public int TrackId { get; set; }

    public int BucketId { get; set; }

    public string TrackName { get; set; } = null!;

    public int BranchCode { get; set; }

    public bool IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
