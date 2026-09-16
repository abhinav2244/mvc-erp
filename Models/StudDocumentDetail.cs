using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudDocumentDetail
{
    public int? StudId { get; set; }

    public int? DocId { get; set; }

    public string? DocPath { get; set; }

    public string? Remark { get; set; }
}
