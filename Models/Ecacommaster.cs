using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Ecacommaster
{
    public int ComId { get; set; }

    public int ExCurActComId { get; set; }

    public string ExCurActComName { get; set; } = null!;

    public string? ExCurActComDesc { get; set; }
}
