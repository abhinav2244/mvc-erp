using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BrowserLink
{
    public int Id { get; set; }

    public string LnkType { get; set; } = null!;

    public string? Link { get; set; }
}
