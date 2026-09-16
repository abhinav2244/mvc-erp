using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class SessionStratEnd
{
    public int SessionId { get; set; }

    public string ClassLevel { get; set; } = null!;

    public int? BranchCode { get; set; }

    public string Semester { get; set; } = null!;

    public DateOnly SessionStart { get; set; }

    public DateOnly SessionEnd { get; set; }

    public string AcadYear { get; set; } = null!;

    public string AcadSession { get; set; } = null!;
}
