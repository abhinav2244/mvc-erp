using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstBatch
{
    public int BatchId { get; set; }

    public string? BatchName { get; set; }

    public string? ClassLevel { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public string? Flag { get; set; }
}
