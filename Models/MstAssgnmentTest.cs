using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAssgnmentTest
{
    public int Atid { get; set; }

    public int? TeacherId { get; set; }

    public string? QueType { get; set; }

    public string? AssgTest { get; set; }

    public string? AcadYear { get; set; }

    public int? BranchCode { get; set; }

    public string? Class { get; set; }

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public int? SubjectCode { get; set; }

    public string? Title { get; set; }

    public DateOnly? PublishDate { get; set; }

    public TimeOnly? PreStartTime { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public short? TotalTime { get; set; }

    public short? TotalQue { get; set; }

    public DateOnly? CreateDate { get; set; }

    public bool? IsDelete { get; set; }

    public DateOnly? AssStartDate { get; set; }

    public DateOnly? AssEndDate { get; set; }

    public string? QuePdfPath { get; set; }
}
