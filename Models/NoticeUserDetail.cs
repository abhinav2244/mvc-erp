using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class NoticeUserDetail
{
    public decimal NUDId { get; set; }

    public int? NoticeId { get; set; }

    public int? UserId { get; set; }
}
