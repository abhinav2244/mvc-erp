using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Internship
{
    public int InternshipId { get; set; }

    public int StudentId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Role { get; set; }

    public string? Description { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsDelete { get; set; }
}
