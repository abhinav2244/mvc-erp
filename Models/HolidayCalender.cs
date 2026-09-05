using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HolidayCalender
{
    public int Id { get; set; }

    public DateTime? EventDate { get; set; }

    public string? Discription { get; set; }

    public int? UserId { get; set; }
}
