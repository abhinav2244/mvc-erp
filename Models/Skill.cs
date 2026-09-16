using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Skill
{
    public int SkillId { get; set; }

    public int StudentId { get; set; }

    public string SkillName { get; set; } = null!;

    public string? ProficiencyLevel { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsDelete { get; set; }
}
