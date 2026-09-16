using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QWithedStudent
{
    public string? RollNumber { get; set; }

    public string? WithheldRemark { get; set; }

    public int? Examid { get; set; }

    public int? Examyearid { get; set; }
}
