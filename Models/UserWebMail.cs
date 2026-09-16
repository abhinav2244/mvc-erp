using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class UserWebMail
{
    public int? UwmId { get; set; }

    public int? UserId { get; set; }

    public string? UserLogin { get; set; }

    public string? Password { get; set; }
}
