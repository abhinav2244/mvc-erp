using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ReExamFormsDetail
{
    public int ReExamDetId { get; set; }

    public int? ReExamId { get; set; }

    public int? ReExamSubId { get; set; }

    public bool? IsDelete { get; set; }
}
