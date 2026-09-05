using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstNepbasket
{
    public int BasketId { get; set; }

    public string? MejorSubjectName { get; set; }

    public string? MinorSubjectName { get; set; }

    public int? MejorSubjectCode { get; set; }

    public string? MinorSubjectCode { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? ClassLevel { get; set; }

    public int? IsActive { get; set; }
}
