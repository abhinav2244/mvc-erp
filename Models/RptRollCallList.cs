using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class RptRollCallList
{
    public int? Id { get; set; }

    public string? StudName { get; set; }

    public string? StudSemester { get; set; }

    public string? StudEnrollNo { get; set; }

    public DateTime? AdmnDate { get; set; }

    public int? SrNo { get; set; }
}
