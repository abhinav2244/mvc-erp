using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstLeaveType
{
    public int Ltid { get; set; }

    public string LeaveType { get; set; } = null!;

    public bool IsDelete { get; set; }
}
