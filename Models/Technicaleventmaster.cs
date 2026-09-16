using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Technicaleventmaster
{
    public int TEId { get; set; }

    public int? TechId { get; set; }

    public string? TechName { get; set; }

    public string? TechDesc { get; set; }
}
