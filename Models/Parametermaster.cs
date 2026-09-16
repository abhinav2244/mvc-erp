using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Parametermaster
{
    public string? DescriptionId { get; set; }

    public string ReferenceId { get; set; } = null!;

    public string? Description { get; set; }
}
