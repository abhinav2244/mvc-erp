using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstNotEligibleStudForFeedback
{
    public int Nesid { get; set; }

    public int? StudId { get; set; }

    public string? StudUsername { get; set; }

    public string? AcadYear { get; set; }

    public bool? IsDelete { get; set; }
}
