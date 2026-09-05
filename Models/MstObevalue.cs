using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstObevalue
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? ValueName { get; set; }

    public bool? IsDelete { get; set; }
}
