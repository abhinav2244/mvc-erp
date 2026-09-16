using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Sportmaster
{
    public int SMId { get; set; }

    public int SportId { get; set; }

    public string? SportName { get; set; }

    public string? SportDesc { get; set; }
}
