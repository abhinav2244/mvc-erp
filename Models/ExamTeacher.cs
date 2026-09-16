using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamTeacher
{
    public int Id { get; set; }

    public string ClassLevel { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public int BranchCode { get; set; }

    public string? Semester { get; set; }

    public int SubjectCode { get; set; }

    public int? TeacherId { get; set; }

    public bool IsVerified { get; set; }

    public int? CatId { get; set; }

    public string? Category { get; set; }
}
