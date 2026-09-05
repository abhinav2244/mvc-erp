using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Culturaleventmaster
{
    public int CMId { get; set; }

    public int? CulId { get; set; }

    public string? CulName { get; set; }

    public string? CulDesc { get; set; }
}
