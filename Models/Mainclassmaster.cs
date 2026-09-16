using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Mainclassmaster
{
    public string? ClassAbbr { get; set; }

    public string ClassId { get; set; } = null!;

    public string? ClassName { get; set; }

    public string? ClassLevel { get; set; }

    public string? ClassFaculty { get; set; }

    public string? ClassDuration { get; set; }

    public string? BaseClass { get; set; }
}
