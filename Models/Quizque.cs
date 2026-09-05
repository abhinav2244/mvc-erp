using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Quizque
{
    public decimal? Qno { get; set; }

    public string Question { get; set; } = null!;

    public string Op1 { get; set; } = null!;

    public string Op2 { get; set; } = null!;

    public string Op3 { get; set; } = null!;

    public string Op4 { get; set; } = null!;

    public string Cop { get; set; } = null!;

    public decimal Userid { get; set; }
}
