using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class FeedbackDetail
{
    public int DetId { get; set; }

    public int? FeedId { get; set; }

    public int? DetQueFeedId { get; set; }

    public string? DetQueAns { get; set; }

    public int? DetQueMark { get; set; }

    public string? DetIsDeleted { get; set; }

    public virtual Feedback? Feed { get; set; }
}
