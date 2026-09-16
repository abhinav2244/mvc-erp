using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstLeaveApplicationAction
{
    public int ActionId { get; set; }

    public int LeaveAppId { get; set; }

    public int ForwardedByCatId { get; set; }

    public int ForwardedToCatId { get; set; }

    public int ForwardedById { get; set; }

    public int ForwardedToId { get; set; }

    public DateOnly ForwardDate { get; set; }

    public string AppStatus { get; set; } = null!;

    public string? Remark { get; set; }
}
