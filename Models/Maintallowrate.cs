using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Maintallowrate
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? Group { get; set; }

    public int? Ds { get; set; }

    public int? Hs { get; set; }

    public int? Ghs { get; set; }
}
