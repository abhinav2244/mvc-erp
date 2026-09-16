using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MasterStudApplication
{
    public int AppId { get; set; }

    public string? AppCode { get; set; }

    public string? AppName { get; set; }

    public string? AppDescription { get; set; }
}
