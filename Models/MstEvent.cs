using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstEvent
{
    public int EventId { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public int? EventType { get; set; }

    public string? Activity { get; set; }

    public int? LevelType { get; set; }

    public string? SubjectTopic { get; set; }

    public string? EventName { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Venue { get; set; }

    public int? ParticipantsCount { get; set; }

    public string? FinanceType { get; set; }

    public double? Amount { get; set; }

    public bool? IsDelete { get; set; }

    public string? UploadedDocument { get; set; }
}
