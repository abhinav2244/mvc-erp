using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstDivision
{
    public int DivisionId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public string? Division { get; set; }

    public double? RangeFrom { get; set; }

    public double? RangeTo { get; set; }

    public bool? IsDelete { get; set; }
}
