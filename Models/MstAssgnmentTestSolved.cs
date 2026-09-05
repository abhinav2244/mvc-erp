using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAssgnmentTestSolved
{
    public int Atsid { get; set; }

    public int? Atid { get; set; }

    public int? StudId { get; set; }

    public short? TotalQue { get; set; }

    public bool? IsSubmit { get; set; }

    public double? ObtainMarks { get; set; }

    public double? TotalMarks { get; set; }

    public string? AnsPdfPath { get; set; }
}
