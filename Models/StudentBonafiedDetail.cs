using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentBonafiedDetail
{
    public int ApplicationId { get; set; }

    public int StudId { get; set; }

    public string DepartmentId { get; set; } = null!;

    public string StudAcadYear { get; set; } = null!;

    public string StudClass { get; set; } = null!;

    public string? StudSemester { get; set; }

    public int BranchCode { get; set; }

    public string Status { get; set; } = null!;

    public DateTime AppliedDate { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public bool? Isdawounload { get; set; }

    public string? Remarks { get; set; }
}
