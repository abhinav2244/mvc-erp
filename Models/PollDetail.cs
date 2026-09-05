using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class PollDetail
{
    public decimal PDId { get; set; }

    public decimal? PMId { get; set; }

    public int? UserId { get; set; }

    public int? UserResponse { get; set; }
}
