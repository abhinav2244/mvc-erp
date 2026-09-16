using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstGender
{
    public int GenderId { get; set; }

    public string? Gender { get; set; }

    public string? GenderCode { get; set; }

    public string? GenderAbb { get; set; }
}
