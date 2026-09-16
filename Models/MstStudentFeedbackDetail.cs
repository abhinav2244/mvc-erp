using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStudentFeedbackDetail
{
    public int? Sfid { get; set; }

    public int? QueId { get; set; }

    public string? SelectedOption { get; set; }

    public short? OptionValue { get; set; }

    public virtual MstStudentFeedback? Sf { get; set; }
}
