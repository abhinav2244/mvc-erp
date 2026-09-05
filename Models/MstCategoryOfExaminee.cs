using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstCategoryOfExaminee
{
    public int CategoryOfExamineeId { get; set; }

    public string? CategoryOfExaminee { get; set; }

    public string? CategoryOfExamineeCode { get; set; }

    public bool? IsDelete { get; set; }
}
