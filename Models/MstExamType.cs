using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstExamType
{
    public int ExamTypeId { get; set; }

    public string? ExamType { get; set; }

    public bool? IsSync { get; set; }

    public bool? IsActive { get; set; }

    public string? ExamTypeCode { get; set; }
}
