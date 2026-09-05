using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class DepartmentDoc
{
    public int DocumentId { get; set; }

    public string? Department { get; set; }

    public string? Title { get; set; }

    public string? FilePath { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? Status { get; set; }

    public string? FileType { get; set; }

    public int? SubDepartmentId { get; set; }
}
