using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstGrade
{
    public int GradeId { get; set; }

    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public string? Grade { get; set; }

    public string? Description { get; set; }

    public int? RangeFrom { get; set; }

    public int? Rangeto { get; set; }

    public string? GradePoint { get; set; }
}
