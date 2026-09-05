using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstExamAbsoluteResult
{
    public int ExamId { get; set; }

    public int ExamYearId { get; set; }

    public int ExamSubjectId { get; set; }

    public string? SubjectCode { get; set; }

    public double? Aa { get; set; }

    public double? Ab { get; set; }

    public double? Ba { get; set; }

    public double? Bb { get; set; }

    public double? Ca { get; set; }

    public double? Cb { get; set; }

    public double? Cc { get; set; }

    public bool? IsSubmit { get; set; }

    public bool? IsVerify { get; set; }
}
