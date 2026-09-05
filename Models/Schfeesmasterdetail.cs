using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Schfeesmasterdetail
{
    public string? FeesTypeId { get; set; }

    public string? FeesName { get; set; }

    public string? ClassId { get; set; }

    public double? Amount { get; set; }

    public double? Ebcamount { get; set; }

    public double? Goiamount { get; set; }

    public string? SubGroup { get; set; }

    public int? BranchCode { get; set; }

    public string? FeesType { get; set; }

    public string? ClassLevel { get; set; }

    public int? SrNo { get; set; }
}
