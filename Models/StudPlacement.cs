using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudPlacement
{
    public int Studid { get; set; }

    public string StudName { get; set; } = null!;

    public string Branch { get; set; } = null!;

    public string AcadYear { get; set; } = null!;

    public string? StudSkill { get; set; }

    public string? ResumTitle { get; set; }

    public string? Resume { get; set; }

    public string? ResumeIndex { get; set; }

    public string? CompanyName { get; set; }

    public DateTime? SelectionDt { get; set; }

    public string? Select { get; set; }

    public string? CriteriaSelect { get; set; }

    public string? LanguageKnown { get; set; }

    public string CourseLevel { get; set; } = null!;

    public string? EmailId { get; set; }

    public string? OptEmailId { get; set; }

    public string? MobileNo { get; set; }
}
