using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StatementaAbstract
{
    public short? PageNo { get; set; }

    public short? New { get; set; }

    public short? Renew { get; set; }

    public short? Boys { get; set; }

    public short? Girls { get; set; }

    public double? MAllowance { get; set; }

    public double? TuitionFee { get; set; }

    public double? ExamFee { get; set; }

    public double? OtherFee { get; set; }

    public double? TotalFee { get; set; }

    public string? Remarks { get; set; }

    public string? AcadYear { get; set; }

    public string? Category { get; set; }

    public int? OrderNo { get; set; }
}
