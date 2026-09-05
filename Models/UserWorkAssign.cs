using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class UserWorkAssign
{
    public int WkId { get; set; }

    public string? WkUserLogin { get; set; }

    public int? WkMainId { get; set; }

    public int? WkSubId { get; set; }

    public string? WkFormName { get; set; }

    public string? WkFormLink { get; set; }

    public string? WkFlag { get; set; }

    public string? WkAuthBy { get; set; }

    public string? WkModuleName { get; set; }

    public string? WkCollegeCode { get; set; }

    public string? WkImage { get; set; }
}
