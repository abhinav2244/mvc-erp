using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstDriveStudent
{
    public long Dsid { get; set; }

    public int DriveId { get; set; }

    public string? AcadYear { get; set; }

    public int StudId { get; set; }

    public string? BatchName { get; set; }

    public bool? IsPresent { get; set; }

    public bool? IsSelect { get; set; }

    public bool? IsJoin { get; set; }
}
