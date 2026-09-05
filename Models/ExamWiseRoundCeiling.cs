using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamWiseRoundCeiling
{
    public int Rcid { get; set; }

    public int? Examid { get; set; }

    public string? RoundCeilingType { get; set; }
}
