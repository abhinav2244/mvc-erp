using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstGraceTable
{
    public int Graceid { get; set; }

    public int? RangeFrom { get; set; }

    public int? Rangeto { get; set; }

    public string? GraceMarksUpto { get; set; }

    public string? Remarks { get; set; }
}
