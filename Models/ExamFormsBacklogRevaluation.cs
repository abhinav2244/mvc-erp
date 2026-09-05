using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamFormsBacklogRevaluation
{
    public int BackRevalFormId { get; set; }

    public int BackRevalExamId { get; set; }

    public int BackRevalExamYearId { get; set; }

    public int ExamFormId { get; set; }

    public int BackExamId { get; set; }

    public int BackExamYearId { get; set; }

    public int StudId { get; set; }

    public int AssessmentId { get; set; }

    public int? RoomNo { get; set; }

    public int? BuildingId { get; set; }

    public bool? IsFeesPaid { get; set; }

    public bool? IsSubmit { get; set; }

    public bool? IsApprove { get; set; }

    public int? AttemptId { get; set; }

    public DateOnly? ApplicationDate { get; set; }

    public bool? IsWithheld { get; set; }

    public bool? WithheldSaved { get; set; }

    public string? WithheldRemark { get; set; }
}
