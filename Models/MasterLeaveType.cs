using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MasterLeaveType
{
    public int TypeSrNo { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeLeaveType { get; set; }

    public int? TypeTotal { get; set; }

    public string? TypeClassLevel { get; set; }

    public int? MaxLeaves { get; set; }

    public string? AcadYear { get; set; }

    public string? TodayOnward { get; set; }
}
