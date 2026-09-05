using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QueFeedbackOption
{
    public int Pid { get; set; }

    public string? Grade { get; set; }

    public string? PindexRange { get; set; }

    public int? Marks { get; set; }

    public int? QueId { get; set; }
}
