using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Logintime
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? LoginIntime { get; set; }

    public string? LoginOuttime { get; set; }

    public string? DateToday { get; set; }
}
