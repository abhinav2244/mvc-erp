using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamInternalMarksEntry
{
    public int Imsid { get; set; }

    public int? MarksheetId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamFormId { get; set; }

    public int? ExamSubjectId { get; set; }

    public double? Assignment1 { get; set; }

    public double? Assignment2 { get; set; }

    public double? Mse1 { get; set; }

    public double? Mse2 { get; set; }

    public double? Mse3 { get; set; }

    public double? PracticalInternal { get; set; }

    public double? Assignment3 { get; set; }

    public double? Mse4 { get; set; }

    public double? Mse5 { get; set; }

    public bool? IsSubmit { get; set; }

    public string? Remark { get; set; }

    public bool? IsMse1absent { get; set; }

    public bool? IsMse2absent { get; set; }

    public bool? IsMse3absent { get; set; }

    public bool? IsPracticalAbsent { get; set; }

    public double? Assignment1ReExam { get; set; }

    public double? Assignment2ReExam { get; set; }

    public double? Mse1ReExam { get; set; }

    public double? Mse2ReExam { get; set; }

    public double? Mse3ReExam { get; set; }

    public bool? IsPracticalAbsentReExam { get; set; }

    public bool? IsMse1absentReExam { get; set; }

    public bool? IsMse2absentReExam { get; set; }

    public bool? IsMse3absentReExam { get; set; }

    public double? PracticalInternalReExam { get; set; }

    public bool? IsSubmitReExam { get; set; }
}
