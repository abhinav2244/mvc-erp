using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Certificate
{
    public int CertificateId { get; set; }

    public int StudentId { get; set; }

    public string Title { get; set; } = null!;

    public string? IssuedBy { get; set; }

    public DateOnly? IssueDate { get; set; }

    public string? CertificateUrl { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsDelete { get; set; }
}
