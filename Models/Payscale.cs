using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Payscale
{
    public int Id { get; set; }

    public string? Payscale1 { get; set; }

    public int? DsgId { get; set; }

    public short? FilledPosts { get; set; }

    public string? Used { get; set; }

    public int? ApprPosts { get; set; }
}
