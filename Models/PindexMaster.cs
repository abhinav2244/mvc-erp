using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class PindexMaster
{
    public int Pid { get; set; }

    public string? Grade { get; set; }

    public double? FromPindex { get; set; }

    public double? ToPindex { get; set; }

    public string? Remark { get; set; }
}
