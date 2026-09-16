using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstCenterBuilding
{
    public int BuildingId { get; set; }

    public string? BuildingName { get; set; }

    public int? CenterId { get; set; }

    public int? BuildingCapacity { get; set; }

    public int? NoOfRooms { get; set; }

    public int? RoomAllocated { get; set; }

    public int? SeatsAllocated { get; set; }

    public string? Flag { get; set; }

    public bool? IsDelete { get; set; }
}
