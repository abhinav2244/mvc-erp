using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstDay
{
    public int DayId { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }
}
