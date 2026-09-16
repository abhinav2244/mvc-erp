using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ResultPublicationLog
{
    public int ResultId { get; set; }

    public int? ExamId { get; set; }

    public DateOnly? ProvisionalDeclareDate { get; set; }

    public DateOnly? RevaluationDeclareDate { get; set; }

    public DateOnly? FinalDeclareDate { get; set; }

    public DateOnly? ReExamDeclareDate { get; set; }

    public DateOnly? BacklogDeclareDate { get; set; }

    public DateOnly? BackRevaluationDeclareDate { get; set; }

    public DateOnly? ModifiedProvisionalDeclareDate { get; set; }

    public DateOnly? ModifiedRevaluationDeclareDate { get; set; }

    public DateOnly? ModifiedFinalDeclareDate { get; set; }

    public DateOnly? ModifiedReExamDeclareDate { get; set; }

    public DateOnly? ModifiedBacklogDeclareDate { get; set; }

    public DateOnly? ModifiedBackRevaluationDeclareDate { get; set; }
}
