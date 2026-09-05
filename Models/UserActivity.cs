using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class UserActivity
{
    public int ActivityId { get; set; }

    public string? UserId { get; set; }

    public DateTime? LoginTime { get; set; }

    public DateTime? LogoutTime { get; set; }

    public int? Duration { get; set; }

    public string? OpenedLinks { get; set; }

    public string? Ipaddress { get; set; }

    public string? DeviceInfo { get; set; }
}
