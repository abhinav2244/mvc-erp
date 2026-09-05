using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Attachment
{
    public int AttachmentId { get; set; }

    public int StudentId { get; set; }

    public string EntityType { get; set; } = null!;

    public int EntityId { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? FileType { get; set; }

    public int? FileSize { get; set; }

    public DateTime? UploadedDate { get; set; }

    public bool? IsDelete { get; set; }
}
