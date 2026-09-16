using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TempIdGeneration
{
    public int Id { get; set; }

    public int? Branch { get; set; }

    public string? ClassLevel { get; set; }

    public string? StudClass { get; set; }

    public int? IdCode { get; set; }
}
