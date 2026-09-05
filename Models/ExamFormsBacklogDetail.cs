using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamFormsBacklogDetail
{
    public int BackDetId { get; set; }

    public int BackFormId { get; set; }

    public int ExamFormId { get; set; }

    public int BacExamYearId { get; set; }

    public int ExamSubjectId { get; set; }

    public double? ObtMarksThext { get; set; }

    public double? ObtMarksPrext { get; set; }

    public bool? IsAbsentThext { get; set; }

    public bool? IsAbsentPrext { get; set; }

    public bool? IsSubmitThext { get; set; }

    public bool? IsSubmitPrext { get; set; }

    public bool? IsVerifyThext { get; set; }

    public bool? IsVerifyPrext { get; set; }

    public bool? IsDelete { get; set; }

    public string? Result { get; set; }

    public string? Grade { get; set; }

    public int? Examid { get; set; }

    public bool? IsAbsentThverify { get; set; }

    public bool? IsAbsentPrverify { get; set; }

    public string? PassFail { get; set; }

    public bool? AttemptId { get; set; }

    public bool? IsBackRevaluation { get; set; }

    public double? BackRevalThMarks { get; set; }

    public bool? BackRevalThabsent { get; set; }

    public bool? BackRevalThabsentSubmit { get; set; }

    public double? BackRevalPrmarks { get; set; }

    public bool? BackRevalPrabsent { get; set; }

    public bool? BackRevalPrabsentSubmit { get; set; }

    public bool? BackRevalThsubmit { get; set; }

    public bool? BackRevalPrsubmit { get; set; }

    public virtual ExamFormsBacklog BackForm { get; set; } = null!;
}
