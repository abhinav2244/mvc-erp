using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstFacultyandStaff
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public string? SanctionedBy { get; set; }

    public int? Position { get; set; }

    public int? RcruitMale { get; set; }

    public int? RcruitFemale { get; set; }

    public int? RcruitOthers { get; set; }

    public int? Total { get; set; }

    public int? YetToRecruit { get; set; }
}
