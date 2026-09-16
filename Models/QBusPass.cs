using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QBusPass
{
    public int StudId { get; set; }

    public string? StudName { get; set; }

    public string? StudClass { get; set; }

    public string? StudSection { get; set; }

    public byte[]? StudPhoto { get; set; }

    public string? ClassLevel { get; set; }

    public string? StudAcadYear { get; set; }

    public string? StudStatus { get; set; }

    public string? BranchName { get; set; }

    public string? Branch { get; set; }

    public string? UserLogin { get; set; }

    public int? BusRecNo { get; set; }

    public string? StudUserName { get; set; }
}
