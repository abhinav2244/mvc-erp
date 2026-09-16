using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstParentFeedbackDetail
{
    public int? Pfid { get; set; }

    public int? QueId { get; set; }

    public string? SelectedOption { get; set; }

    public short? OptionValue { get; set; }
}
