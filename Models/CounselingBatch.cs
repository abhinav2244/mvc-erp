using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CounselingBatch
{
    public int BatchId { get; set; }

    public string BatchName { get; set; } = null!;

    public string AcadYear { get; set; } = null!;

    public string ClassLevel { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public int BranchCode { get; set; }

    public string? Section { get; set; }

    public int MentorEmpId { get; set; }

    public bool IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<StudentMentorHistory> StudentMentorHistories { get; set; } = new List<StudentMentorHistory>();
}
