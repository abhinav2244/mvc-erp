using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Assgtable
{
    public int AssId { get; set; }

    public string? FacultyId { get; set; }

    public string? AssgNo { get; set; }

    public string? DepartmentId { get; set; }

    public string? Semester { get; set; }

    public string? Subject { get; set; }

    public string? QuesNo { get; set; }

    public string? Emark { get; set; }

    public string? Qtype { get; set; }

    public DateTime? Asstime { get; set; }

    public DateTime? Pubdate { get; set; }

    public string? AcademicYear { get; set; }

    public string? Title { get; set; }

    public string? Section { get; set; }
}
