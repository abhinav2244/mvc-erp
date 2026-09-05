using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstGeneralFeedbackDetail
{
    public int? Gfid { get; set; }

    public int? QueId { get; set; }

    public string? SelectedOption { get; set; }

    public short? OptionValue { get; set; }
}
