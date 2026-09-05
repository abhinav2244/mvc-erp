using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstCenter
{
    public int CenterId { get; set; }

    public string? CenterCode { get; set; }

    public string? CenterName { get; set; }

    public string? CenterAddress { get; set; }

    public int? TotalCapacity { get; set; }

    public int? NoOfRooms { get; set; }

    public int? SeatsAllocated { get; set; }

    public bool? IsDelete { get; set; }
}
