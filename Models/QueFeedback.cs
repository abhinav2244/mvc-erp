using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QueFeedback
{
    public int Qid { get; set; }

    public string? Question { get; set; }

    public string? ULogin { get; set; }

    public int? QueSeq { get; set; }

    public string? AuthBy { get; set; }

    public DateTime? SpanDate { get; set; }
}
