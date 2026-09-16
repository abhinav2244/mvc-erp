using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QStuSectionCount
{
    public string? StudSection { get; set; }

    public int? BranchCode { get; set; }

    public string? StudSemester { get; set; }

    public string? StudClass { get; set; }

    public int? CountAsStudent { get; set; }
}
