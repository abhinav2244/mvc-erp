using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Roomallocation
{
    public int? StudGrNo { get; set; }

    public int? StudRollNo { get; set; }

    public string? AcadYear { get; set; }

    public string? RoomId { get; set; }

    public DateTime? AllocateDate { get; set; }

    public string? VacateDate { get; set; }
}
