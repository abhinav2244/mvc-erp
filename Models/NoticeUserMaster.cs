using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class NoticeUserMaster
{
    public int NumId { get; set; }

    public string? UserType { get; set; }

    public int? UserLevel { get; set; }

    public int? AuthorityLevel { get; set; }
}
