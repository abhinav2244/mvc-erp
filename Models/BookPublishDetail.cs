using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BookPublishDetail
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string Isbnno { get; set; } = null!;

    public string Publisher { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public bool? IsDelete { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public string? UploadedDocument { get; set; }
}
