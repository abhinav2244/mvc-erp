using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstPatentDetail
{
    public int PatentId { get; set; }

    public string Title { get; set; } = null!;

    public DateOnly DateOfPublish { get; set; }

    public int PatentType { get; set; }

    public string PatentCategory { get; set; } = null!;

    public string? CertificateLink { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public bool? IsDelete { get; set; }
}
