using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class LevelMaster
{
    public int LvId { get; set; }

    public string LvClass { get; set; } = null!;

    public string? LvAbbr { get; set; }

    public string? LvClevel { get; set; }

    public string? LvUsed { get; set; }
}
