using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QTcdetail
{
    public string? TrustName { get; set; }

    public string? Institute { get; set; }

    public string? Address1 { get; set; }

    public int? StudId { get; set; }

    public string? StudentName { get; set; }

    public int TcNo { get; set; }

    public DateTime? IssueDate { get; set; }

    public string? AcadYear { get; set; }

    public string? SdacadYear { get; set; }

    public string? ClassLevel { get; set; }

    public string Class { get; set; } = null!;

    public string Sdclass { get; set; } = null!;

    public string Branch { get; set; } = null!;

    public string Sdbranch { get; set; } = null!;

    public string TcReason { get; set; } = null!;

    public DateTime? StudAdmissionDate { get; set; }

    public string StudStatus { get; set; } = null!;

    public bool? TcIsCancle { get; set; }

    public string? ConSchStatus { get; set; }

    public string? StudSection { get; set; }
}
