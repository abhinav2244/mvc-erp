using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class SchemeMaster
{
    public int SchemeId { get; set; }

    public string SchemeName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
