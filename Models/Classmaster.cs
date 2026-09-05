using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Classmaster
{
    public string? ClassAbbr { get; set; }

    public string ClassId { get; set; } = null!;

    public string? ClassName { get; set; }

    public string ClassLevel { get; set; } = null!;

    public string? ClassFaculty { get; set; }

    public string? ClassDuration { get; set; }

    public string? BaseClass { get; set; }

    public short? NoOfDivisions { get; set; }

    public short? ClassStrength { get; set; }

    public string? SemesterPattern { get; set; }

    public int? CaseId { get; set; }

    public bool? IsAdmission { get; set; }
}
