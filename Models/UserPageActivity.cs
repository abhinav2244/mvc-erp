using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class UserPageActivity
{
    public long ActivityId { get; set; }

    public long SequenceNo { get; set; }

    public int? UserId { get; set; }

    public long? LoginId { get; set; }

    public string PagePath { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public string? RecordIdentifier { get; set; }

    public string? Details { get; set; }

    public DateTime RecordedAtUtc { get; set; }

    public string InsertedBySvc { get; set; } = null!;

    public bool IsArchived { get; set; }

    public string? Specategory { get; set; }
}
