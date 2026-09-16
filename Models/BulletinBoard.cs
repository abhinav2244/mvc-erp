using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BulletinBoard
{
    public int BId { get; set; }

    public string? Bulletin { get; set; }

    public string? PostedBy { get; set; }

    public DateTime? PostedDate { get; set; }

    public string? Status { get; set; }
}
