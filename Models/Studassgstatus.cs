using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Studassgstatus
{
    public decimal? Id { get; set; }

    public string AssgNo { get; set; } = null!;

    public string Facultyid { get; set; } = null!;

    public string StudUserName { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string AssgStatus { get; set; } = null!;
}
