using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstCenterRoomsDetail
{
    public int Crdid { get; set; }

    public int? RoomNo { get; set; }

    public int? RoomCapacity { get; set; }

    public int? BuildingId { get; set; }

    public string? Flag { get; set; }

    public int? SeatsAllocated { get; set; }

    public bool? IsDelete { get; set; }
}
