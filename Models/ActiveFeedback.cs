using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ActiveFeedback
{
    public int Afid { get; set; }

    public int? BranchCode { get; set; }

    public bool? IsActive { get; set; }
}
