using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstQuestionCategory
{
    public short QueCatId { get; set; }

    public string? CategoryName { get; set; }

    public bool? IsActive { get; set; }
}
