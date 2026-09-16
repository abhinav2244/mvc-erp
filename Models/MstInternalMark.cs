using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstInternalMark
{
    public int IntMid { get; set; }

    public string? AssignmentMsename { get; set; }

    public double? MaxMarks { get; set; }

    public string? Type { get; set; }

    public bool? IsDelete { get; set; }

    public double? MaxMarks2 { get; set; }
}
