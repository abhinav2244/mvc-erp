using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstPlacementDrive
{
    public int DriveId { get; set; }

    public string? DriveType { get; set; }

    public string? DriveName { get; set; }

    public string? CompanyName { get; set; }

    public string? JobProfile { get; set; }

    public string? JobLocation { get; set; }

    public string? RequiredSkills { get; set; }

    public string? DocumentList { get; set; }

    public string? Venue { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public TimeOnly? FromTime { get; set; }

    public TimeOnly? ToTime { get; set; }

    public bool? IsDelete { get; set; }

    public string? AcadYear { get; set; }

    public bool? IsOpen { get; set; }
}
