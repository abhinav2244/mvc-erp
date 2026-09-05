using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStudentFeedback
{
    public int Sfid { get; set; }

    public string? StudUserName { get; set; }

    public int? SubjectCode { get; set; }

    public string? ThPrType { get; set; }

    public int? TeacherId { get; set; }

    public string? UnitTaught { get; set; }

    public string? Remark { get; set; }

    public short? TotalQue { get; set; }

    public short? ObtainMarks { get; set; }

    public short? TotalMarks { get; set; }

    public DateOnly? FeedbackDate { get; set; }

    public string? AcadYear { get; set; }

    public string? AcadSession { get; set; }

    public string? ClassLevel { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public string? Fbattempt { get; set; }
}
