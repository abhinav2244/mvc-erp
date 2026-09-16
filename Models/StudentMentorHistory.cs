using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentMentorHistory
{
    public int Smhid { get; set; }

    public int StudId { get; set; }

    public int BatchId { get; set; }

    public DateOnly FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public bool IsActive { get; set; }

    public int? AssignedBy { get; set; }

    public string? ChangeReason { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual CounselingBatch Batch { get; set; } = null!;

    public virtual ICollection<CounselingRemark> CounselingRemarks { get; set; } = new List<CounselingRemark>();
}
