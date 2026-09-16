using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudBarCode
{
    public int BarId { get; set; }

    public int? StudId { get; set; }

    public string? BarUserId { get; set; }

    public string? BarStudCode { get; set; }

    public string? Status { get; set; }

    public string? BusStatus { get; set; }
}
