using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudExamDetention
{
    public int Sedid { get; set; }

    public string? AcadYear { get; set; }

    public int? StudId { get; set; }

    public string? EnrollmentNumber { get; set; }

    public string? Semester { get; set; }

    public bool? IsDelete { get; set; }
}
