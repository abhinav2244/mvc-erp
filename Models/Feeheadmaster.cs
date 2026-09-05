using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Feeheadmaster
{
    public int Id { get; set; }

    public string? FeeHead { get; set; }

    public string? Nature { get; set; }

    public short? Sequence { get; set; }
}
