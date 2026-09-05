using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstQuestionTypeGroup
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public string? SubTotal { get; set; }

    public bool? IsDelete { get; set; }
}
