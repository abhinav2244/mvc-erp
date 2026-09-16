using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HoliDayDetail
{
    public int SrNo { get; set; }

    public string? Day { get; set; }

    public DateTime? Hdate { get; set; }

    public string? HoliDaysName { get; set; }

    public string? Photo { get; set; }
}
