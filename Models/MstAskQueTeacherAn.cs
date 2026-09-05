using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAskQueTeacherAn
{
    public int AnsId { get; set; }

    public int? Aqtid { get; set; }

    public string? Ans { get; set; }

    public string? FilePath { get; set; }

    public DateOnly? AnsDate { get; set; }
}
