using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstRoomLab
{
    public int Id { get; set; }

    public string RoomType { get; set; } = null!;

    public string RoomName { get; set; } = null!;

    public int? Capacity { get; set; }

    public int? BranchCode { get; set; }
}
