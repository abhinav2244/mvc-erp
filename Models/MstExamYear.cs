using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstExamYear
{
    public int ExamYearId { get; set; }

    public int? ExamTypeId { get; set; }

    public string? Year { get; set; }

    public bool? IsSync { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsCurrentYear { get; set; }
}
