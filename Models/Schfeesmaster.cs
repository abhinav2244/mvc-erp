using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Schfeesmaster
{
    public string? FeesTypeId { get; set; }

    public string? FeesDescription { get; set; }

    public string? FeesType { get; set; }

    public double? FullAmount { get; set; }

    public double? ScholarshipAmount { get; set; }

    public double? ConcessionAmount { get; set; }

    public string? ClassLevel { get; set; }
}
