using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Activefeed
{
    public int? ActId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int? DeptCode { get; set; }

    public string? Activate { get; set; }

    public string? Fbattempt { get; set; }
}
