using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Chat
{
    public int Id { get; set; }

    public string From { get; set; } = null!;

    public string? To { get; set; }

    public string? Message { get; set; }

    public string? Sent { get; set; }

    public string? Recd { get; set; }
}
