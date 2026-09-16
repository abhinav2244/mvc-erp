using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstGradePoint
{
    public int Gdid { get; set; }

    public string? Grade { get; set; }

    public double? GradePoint { get; set; }

    public string? Remark { get; set; }
}
