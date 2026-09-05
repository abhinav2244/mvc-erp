using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstTimeTable
{
    public int Ttid { get; set; }

    public string? AcadYear { get; set; }

    public string? ClassLevel { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public int? BranchCode { get; set; }

    public int? SubjectCode { get; set; }

    public string? ThPrtype { get; set; }

    public string? Section { get; set; }

    public int? DayId { get; set; }

    public TimeOnly? FromTime { get; set; }

    public TimeOnly? ToTime { get; set; }

    public int? EmployeeId { get; set; }

    public int? RoomId { get; set; }

    public int? BatchId { get; set; }
}
