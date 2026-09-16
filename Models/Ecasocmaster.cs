using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Ecasocmaster
{
    public int SocId { get; set; }

    public int ExCurActSocId { get; set; }

    public string ExCurActSocName { get; set; } = null!;

    public string? ExCurActSocDesc { get; set; }
}
