using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QTcreportAcaddetail
{
    public int? StudId { get; set; }

    public int? StudGrno { get; set; }

    public string? StudAcadYear { get; set; }

    public string? StudFirstName { get; set; }

    public string? Studmiddlename { get; set; }

    public string? StudLastName { get; set; }

    public string? StudCommunityId { get; set; }

    public string? StudMothertongueId { get; set; }

    public string? Mothertoung { get; set; }

    public string? Community { get; set; }

    public string? StudStatus { get; set; }

    public string? StudSection { get; set; }

    public string? StudSemester { get; set; }

    public string? BaseClass { get; set; }

    public DateTime? BaseClassAdmissionDate { get; set; }

    public string? LastClass { get; set; }
}
