using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstPaperConference
{
    public int ConfId { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public string? Title { get; set; }

    public string? Name { get; set; }

    public int? LevelType { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Venue { get; set; }

    public int? FianaceType { get; set; }

    public double? Amount { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? IsDelete { get; set; }

    public string? UploadedDocument { get; set; }
}
