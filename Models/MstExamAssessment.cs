using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstExamAssessment
{
    public int Eaid { get; set; }

    public string? AssessmentType { get; set; }

    public int? AssessmentCode { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsActive { get; set; }
}
