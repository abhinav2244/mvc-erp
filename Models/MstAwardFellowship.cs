using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAwardFellowship
{
    public int Afid { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public string? RecordType { get; set; }

    public string? AwardYear { get; set; }

    public int? LevelType { get; set; }

    public int? DesignationId { get; set; }

    public string? AwardName { get; set; }

    public string? ReceivedFrom { get; set; }

    public DateOnly? CreateDate { get; set; }

    public bool? IsDelete { get; set; }

    public string? UploadedPhoto { get; set; }
}
