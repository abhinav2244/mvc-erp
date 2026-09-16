using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QOldFeePaid
{
    public int? StudId { get; set; }

    public string? StudAcadYear { get; set; }

    public double OldFeesPaid { get; set; }
}
