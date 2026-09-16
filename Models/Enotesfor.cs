using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Enotesfor
{
    public int ENId { get; set; }

    public int EnotesId { get; set; }

    public int EmpId { get; set; }

    public int BranchCode { get; set; }

    public string ClassId { get; set; } = null!;

    public string Semester { get; set; } = null!;

    public string Section { get; set; } = null!;
}
