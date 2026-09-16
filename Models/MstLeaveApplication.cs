using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstLeaveApplication
{
    public int LeaveAppId { get; set; }

    public string? AcadYear { get; set; }

    public int EmployeeId { get; set; }

    public int AppAsId { get; set; }

    public int Ltid { get; set; }

    public bool IsHalfDay { get; set; }

    public DateOnly? AppDate { get; set; }

    public DateOnly FromDate { get; set; }

    public DateOnly ToDate { get; set; }

    public double LeaveCount { get; set; }

    public string? Reason { get; set; }

    public int? AlternateEmployee { get; set; }

    public string? AppStatus { get; set; }

    public string? AttachmentPath { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsLwp { get; set; }

    public int? AltEmpCount { get; set; }
}
