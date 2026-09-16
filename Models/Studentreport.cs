using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Studentreport
{
    public int? Id { get; set; }

    public int? StudId { get; set; }

    public string? StudUserName { get; set; }

    public string? UserLogin { get; set; }
}
