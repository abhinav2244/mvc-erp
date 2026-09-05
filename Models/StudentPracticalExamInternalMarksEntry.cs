using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentPracticalExamInternalMarksEntry
{
    public int Pimid { get; set; }

    public string ClassId { get; set; } = null!;

    public string Semester { get; set; } = null!;

    public int BranchCode { get; set; }

    public int SubjectCode { get; set; }

    public string Section { get; set; } = null!;

    public string AcadYear { get; set; } = null!;

    public string? SubjectType { get; set; }

    public int? StudId { get; set; }

    public int? TopicId { get; set; }

    public double? MarksA { get; set; }

    public double? MarksB { get; set; }

    public double? MarksC { get; set; }

    public double? MarksD { get; set; }

    public double? MarksE { get; set; }

    public double? Total { get; set; }

    public string? Remark { get; set; }

    public bool? PracticalInternalSubmit { get; set; }

    public int? EmployeeId { get; set; }

    public int? BatchId { get; set; }
}
