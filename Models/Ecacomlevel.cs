using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Ecacomlevel
{
    public int ELId { get; set; }

    public int EcaComLevelId { get; set; }

    public string EcaComLevelName { get; set; } = null!;

    public string? EcaComLevelDesc { get; set; }
}
