using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Bulletin
{
    public int Id { get; set; }

    public string? Buletboard { get; set; }

    public string? PostBy { get; set; }

    public string? Title { get; set; }

    public string? Message { get; set; }

    public string? PostDate { get; set; }

    public string? PostTime { get; set; }

    public string? Attach { get; set; }

    public string? AttachType { get; set; }
}
