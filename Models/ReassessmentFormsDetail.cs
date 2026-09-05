using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ReassessmentFormsDetail
{
    public int ReassDetId { get; set; }

    public int? ReassId { get; set; }

    public int? ReassSubId { get; set; }

    public bool? IsDelete { get; set; }
}
