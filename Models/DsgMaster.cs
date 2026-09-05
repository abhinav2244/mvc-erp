using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class DsgMaster
{
    public int Id { get; set; }

    public string? Designation { get; set; }

    public string? Type { get; set; }

    public string? Grade { get; set; }

    public short? ApprPosts { get; set; }

    public string? Used { get; set; }

    public int? SrId { get; set; }
}
