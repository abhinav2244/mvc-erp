using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstGeneralFeedback
{
    public int Gfid { get; set; }

    public string? StudUserName { get; set; }

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
