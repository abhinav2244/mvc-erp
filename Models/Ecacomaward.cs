using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Ecacomaward
{
    public int AId { get; set; }

    public int AwardId { get; set; }

    public string AwardName { get; set; } = null!;

    public string? AwardDesc { get; set; }
}
