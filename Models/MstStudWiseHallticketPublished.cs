using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStudWiseHallticketPublished
{
    public int Shpid { get; set; }

    public int? StudId { get; set; }

    public string? EnrollmentNumber { get; set; }

    public int? ExamId { get; set; }

    public string? AcadYear { get; set; }

    public bool? IsNotPublished { get; set; }
}
