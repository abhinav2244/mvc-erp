using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string? UnitType { get; set; }

    public string? UnitName { get; set; }

    public int? UnitValue { get; set; }
}
