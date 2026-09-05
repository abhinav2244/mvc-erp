using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HeadsMaster
{
    public int Id { get; set; }

    public int? MaxHead { get; set; }

    public int? MinHead { get; set; }

    public int? BranchCode { get; set; }

    public string? Semester { get; set; }

    public string? ClassLevel { get; set; }

    public string? AccadYear { get; set; }

    public string? AcadSession { get; set; }
}
