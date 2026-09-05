using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Studcertificatedatum
{
    public int? StudId { get; set; }

    public string? StudAcadYear { get; set; }

    public string? Certificate { get; set; }

    public int? BranchCode { get; set; }
}
