using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstQuestion
{
    public int QueId { get; set; }

    public short? QueCatId { get; set; }

    public string? Question { get; set; }

    public short? OptionId { get; set; }

    public short? QueSequence { get; set; }

    public string? ThPrType { get; set; }

    public bool? IsActive { get; set; }

    public int? GroupId { get; set; }
}
