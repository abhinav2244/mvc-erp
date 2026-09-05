using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstParentFeedback
{
    public int Pfid { get; set; }

    public string? ParentName { get; set; }

    public string? ParentAddress { get; set; }

    public string? MobileNo { get; set; }

    public string? Email { get; set; }

    public string? AcadYear { get; set; }

    public DateOnly? FeedbackDate { get; set; }

    public short? TotalQue { get; set; }

    public double? ObtainMarks { get; set; }

    public double? TotalMarks { get; set; }

    public string? ChildClass { get; set; }
}
