using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Orderdatum
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? CategoryName { get; set; }

    public string? PlanStatus { get; set; }

    public string? Description { get; set; }
}
