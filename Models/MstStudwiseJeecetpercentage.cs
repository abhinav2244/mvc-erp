using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStudwiseJeecetpercentage
{
    public int Spid { get; set; }

    public int? StudId { get; set; }

    public string? EntranceExamType { get; set; }

    public string? AcadYear { get; set; }

    public double? Score { get; set; }

    public bool? IsDelete { get; set; }

    public DateOnly? UploadDate { get; set; }

    public string? Semester { get; set; }

    public int? BranchCode { get; set; }
}
