using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Assgendtime
{
    public string? AssgNo { get; set; }

    public string? Studid { get; set; }

    public string? FacultyId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Subject { get; set; }

    public string? Title { get; set; }

    public string? Qtype { get; set; }
}
