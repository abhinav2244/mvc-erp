using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Adhocdetail
{
    public int Id { get; set; }

    public DateTime? CheckDate { get; set; }

    public string? CheckNo { get; set; }

    public string? Category { get; set; }

    public int? Amount { get; set; }

    public string? AcadYear { get; set; }

    public short? OrderRemark { get; set; }
}
