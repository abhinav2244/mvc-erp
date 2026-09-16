using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ReExammentForm
{
    public int ReExamId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamFormId { get; set; }

    public int? AssessmentId { get; set; }

    public DateOnly? ApplicationDate { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsApprove { get; set; }

    public bool? IsSubmit { get; set; }

    public bool? IsWithheld { get; set; }

    public bool? WithheldSaved { get; set; }

    public string? WithheldRemark { get; set; }

    public int? CenterId { get; set; }
}
