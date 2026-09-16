using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstEnotesDetail
{
    public int Endid { get; set; }

    public int? Enid { get; set; }

    public string? AttachmentLink { get; set; }

    public bool? IsDelete { get; set; }

    public int? ViewCount { get; set; }
}
