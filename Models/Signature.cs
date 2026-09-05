using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Signature
{
    public string Userid { get; set; } = null!;

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public string? Address { get; set; }

    public string? Phno { get; set; }
}
