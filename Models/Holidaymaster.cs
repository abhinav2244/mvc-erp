using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Holidaymaster
{
    public string? Head { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? HolidayTag { get; set; }

    public int Id { get; set; }
}
