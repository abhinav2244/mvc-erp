using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAlumniFeedback
{
    public int Afid { get; set; }

    public int? AlumniId { get; set; }

    public string? Remark { get; set; }

    public short? TotalQue { get; set; }

    public short? ObtainMarks { get; set; }

    public short? TotalMarks { get; set; }

    public DateOnly? FeedbackDate { get; set; }
}
