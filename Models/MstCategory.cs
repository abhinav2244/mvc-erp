using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstCategory
{
    public int CatId { get; set; }

    public string? Category { get; set; }

    public bool? IsDelete { get; set; }

    public string? CatgCode { get; set; }
}
