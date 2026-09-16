using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstSpecialCategory
{
    public int Id { get; set; }

    public int CatId { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool? Isdelete { get; set; }
}
