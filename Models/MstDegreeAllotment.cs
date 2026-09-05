using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstDegreeAllotment
{
    public int DegreeId { get; set; }

    public int? StudId { get; set; }

    public string? RollNumber { get; set; }

    public string? EnrollmentNumber { get; set; }

    public bool? ProvisionalDegree { get; set; }

    public bool? FinalDegree { get; set; }

    public DateOnly? ProDegreeDate { get; set; }

    public DateOnly? FinDegreeDate { get; set; }
}
