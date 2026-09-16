using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstClassWiseRoom
{
    public string? ClassLevel { get; set; }

    public string? Class { get; set; }

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public int? BranchCode { get; set; }

    public int? SubjectCode { get; set; }

    public int? RoomLabId { get; set; }
}
