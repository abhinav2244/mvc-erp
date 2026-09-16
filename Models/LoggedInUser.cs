using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class LoggedInUser
{
    public int LoggedInUserId { get; set; }

    public int UserId { get; set; }

    public DateTime LogTime { get; set; }
}
