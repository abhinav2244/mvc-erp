using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class PlacementRegister
{
    public int Id { get; set; }

    public int? Studid { get; set; }

    public string? ClassLevel { get; set; }

    public string? Branchname { get; set; }

    public string? Companyname { get; set; }

    public DateTime? Campusdate { get; set; }

    public string? Register { get; set; }

    public string? Acadyear { get; set; }

    public DateTime? RegDate { get; set; }
}
