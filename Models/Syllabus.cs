using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Syllabus
{
    public int SylId { get; set; }

    public int SylBranchId { get; set; }

    public string? SylClass { get; set; }

    public string? SylSemester { get; set; }

    public int? SylSubjectCode { get; set; }

    public string? SylUnitNo { get; set; }

    public string? SylUnitName { get; set; }

    public int? SylMarksPerUnit { get; set; }

    public virtual ICollection<SyllabusDetail> SyllabusDetails { get; set; } = new List<SyllabusDetail>();
}
