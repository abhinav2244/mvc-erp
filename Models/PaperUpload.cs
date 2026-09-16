using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class PaperUpload
{
    public int Puid { get; set; }

    public int? Psid { get; set; }

    public int? SetterEmpId { get; set; }

    public DateTime? UploadedOnDate { get; set; }

    public string? Remarks { get; set; }

    public byte[]? FilePath { get; set; }

    public string? OriginalFileName { get; set; }

    public string? FileExtension { get; set; }

    public string? Status { get; set; }
}
