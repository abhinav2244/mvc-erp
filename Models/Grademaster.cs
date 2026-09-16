using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Grademaster
{
    public string? SchoolId { get; set; }

    public string GradeId { get; set; } = null!;

    public string? GradeName { get; set; }

    public DateTime? DateUpdated { get; set; }
}
