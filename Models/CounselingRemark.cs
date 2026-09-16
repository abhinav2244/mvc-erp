using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CounselingRemark
{
    public int RemarkId { get; set; }

    public int Smhid { get; set; }

    public int StudId { get; set; }

    public DateOnly MeetingDate { get; set; }

    public string RemarkType { get; set; } = null!;

    public string RemarkText { get; set; } = null!;

    public string? RiskLevel { get; set; }

    public DateOnly? NextFollowUpDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual StudentMentorHistory Smh { get; set; } = null!;
}
