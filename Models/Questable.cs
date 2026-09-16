using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Questable
{
    public int? Ques { get; set; }

    public string? FacultyId { get; set; }

    public string? AssgNo { get; set; }

    public string? Qno { get; set; }

    public string? Question { get; set; }

    public string? Opt1 { get; set; }

    public string? Opt2 { get; set; }

    public string? Opt3 { get; set; }

    public string? Opt4 { get; set; }

    public string? Answer { get; set; }

    public string? Emark { get; set; }

    public string? Attach { get; set; }
}
