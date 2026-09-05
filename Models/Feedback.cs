using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Feedback
{
    public int FeedId { get; set; }

    public long? StudUserName { get; set; }

    public int? DepartmentName { get; set; }

    public string? Semester { get; set; }

    public DateTime? Feeddate { get; set; }

    public string? Subject { get; set; }

    public int? TeacherName { get; set; }

    public int? Total { get; set; }

    public string? Units { get; set; }

    public string? Section { get; set; }

    public int? RecordNo { get; set; }

    public string? AcadYear { get; set; }

    public string? AcadSession { get; set; }

    public string? ClassId { get; set; }

    public string? ThorPr { get; set; }

    public int? Ans { get; set; }

    public virtual ICollection<FeedbackDetail> FeedbackDetails { get; set; } = new List<FeedbackDetail>();
}
