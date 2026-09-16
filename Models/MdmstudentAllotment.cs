using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MdmstudentAllotment
{
    public int AllotmentId { get; set; }

    public int SessionId { get; set; }

    public int StudentId { get; set; }

    public int SubjectCode { get; set; }

    public int AllottedPreferenceNo { get; set; }

    public int AllotmentRound { get; set; }

    public bool? IsUpgraded { get; set; }

    public DateTime? CreatedDate { get; set; }
}
