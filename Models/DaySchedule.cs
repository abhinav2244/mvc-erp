using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class DaySchedule
{
    public int SchId { get; set; }

    public int? TeacherId { get; set; }

    public string? AcadYear { get; set; }

    public string? AcadSession { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public int? SubjectCode { get; set; }

    public string? ThPrType { get; set; }

    public string? UnitNo { get; set; }

    public short? SchDay { get; set; }

    public DateOnly? SchDate { get; set; }

    public string? Topic { get; set; }

    public string? SubTopic { get; set; }

    public bool? Compliance { get; set; }

    public DateOnly? ComplianceDate { get; set; }

    public string? Remark { get; set; }

    public DateTime? PlanDate { get; set; }

    public bool? ComplianceStatus { get; set; }

    public int? BatchId { get; set; }

    public int? Ilo { get; set; }

    public int? Methodology { get; set; }

    public int? TargetedAtt { get; set; }

    public int? Assessment { get; set; }
}
