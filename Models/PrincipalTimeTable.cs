using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class PrincipalTimeTable
{
    public int Id { get; set; }

    public string? Day { get; set; }

    public string? Class { get; set; }

    public string? _1100AmTo1200Pm { get; set; }

    public string? _1200PmTo100Pm { get; set; }

    public string? _100PmTo130Pm { get; set; }

    public string? _100PmTo200Pm { get; set; }

    public string? _130PmTo230Pm { get; set; }

    public string? _230PmTo330Pm { get; set; }

    public string? _330PmTo430Pm { get; set; }

    public string? _430PmTo530Pm { get; set; }
}
