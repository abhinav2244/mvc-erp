using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Event
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? EventName { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? EventTime { get; set; }

    public string? Location { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }
}
