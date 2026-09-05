using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public int StudentId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Technologies { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsDelete { get; set; }

    public string? ProjectType { get; set; }
}
