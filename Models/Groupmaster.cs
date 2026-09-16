using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Groupmaster
{
    public string GroupId { get; set; } = null!;

    public string? GroupName { get; set; }

    public string? Granted { get; set; }

    public string ClassLevel { get; set; } = null!;
}
