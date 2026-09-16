using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudApplication
{
    public int StudAppId { get; set; }

    public int StudId { get; set; }

    public DateTime? StudDate { get; set; }

    public string? StudTo { get; set; }

    public string? StudInstituteCode { get; set; }

    public string? StudCopyTo { get; set; }

    public string? StudSubCode { get; set; }

    public string? StudComCode { get; set; }

    public string? StudIsDeleted { get; set; }

    public string? StudIsPrinted { get; set; }

    public string? StudUserCode { get; set; }

    public string? StudIsIssued { get; set; }
}
