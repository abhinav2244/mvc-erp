using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstDashboard
{
    public string DashboardId { get; set; } = null!;

    public string? DashboardName { get; set; }

    public byte? DashboardOrder { get; set; }
}
