using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class PeriodTime
{
    public int Id { get; set; }

    public string? Day { get; set; }

    public string? _730AmTo830Am { get; set; }

    public string? _730AmTo930Am { get; set; }

    public string? _830AmTo1030Am { get; set; }

    public string? _830AmTo930Am { get; set; }

    public string? _930AmTo1030Am { get; set; }

    public string? _930AmTo1130Am { get; set; }

    public string? _1030AmTo1100Am { get; set; }

    public string? _1030AmTo1130Am { get; set; }

    public string? _1100AmTo100Pm { get; set; }

    public string? _1100AmTo1200Pm { get; set; }

    public string? _1200PmTo100Pm { get; set; }

    public string? _1200PmTo200Pm { get; set; }

    public string? _100PmTo200Pm { get; set; }
}
