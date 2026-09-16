using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAssgnmentTestSolvedTime
{
    public int TimeId { get; set; }

    public int Atsid { get; set; }

    public DateTime? AttemptDateTime { get; set; }

    public DateTime? LeaveDateTime { get; set; }
}
