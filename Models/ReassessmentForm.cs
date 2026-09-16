using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ReassessmentForm
{
    public int ReassId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamFormId { get; set; }

    public int? AssessmentId { get; set; }

    public DateOnly? ApplicationDate { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsApprove { get; set; }

    public bool? IsSubmit { get; set; }
}
