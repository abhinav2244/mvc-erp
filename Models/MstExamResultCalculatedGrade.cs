using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstExamResultCalculatedGrade
{
    public int ExamId { get; set; }

    public int ExamYearId { get; set; }

    public int ExamSubjectId { get; set; }

    public string? SubjectCode { get; set; }

    public double? Sumoftotal { get; set; }

    public int? N { get; set; }

    public int? M { get; set; }

    public double? Mm { get; set; }

    public double? SumOfxminusM2 { get; set; }

    public double? Sigma { get; set; }

    public double? Aa { get; set; }

    public double? Ab { get; set; }

    public double? Ba { get; set; }

    public double? Bb { get; set; }

    public double? Ca { get; set; }

    public double? Cb { get; set; }

    public double? Cc { get; set; }

    public bool? IsGrademoderate { get; set; }
}
