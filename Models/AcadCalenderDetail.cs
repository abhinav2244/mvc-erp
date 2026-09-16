using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class AcadCalenderDetail
{
    public int Id { get; set; }

    public string? Activity { get; set; }

    public string? ClassLevel { get; set; }

    public string? AcadYear { get; set; }

    public string? AcadSession { get; set; }

    public DateTime? Date { get; set; }
}
