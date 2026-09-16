using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Submaster
{
    public int SubjectCode { get; set; }

    public string? SubjectAbbr { get; set; }

    public string? SubjectName { get; set; }

    public string? SubjectPractical { get; set; }

    public byte? SubjectWorkload { get; set; }

    public string? AcadYear { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public short? InternalMinMarks { get; set; }

    public short? InternalMaxMarks { get; set; }

    public short? OralMinMarks { get; set; }

    public short? OralMaxMarks { get; set; }

    public short? AssignMinMarks { get; set; }

    public short? AssignMaxMarks { get; set; }

    public short? PracticalMinMarks { get; set; }

    public short? PracticalMaxMarks { get; set; }

    public short? TheoryMinMarks { get; set; }

    public short? TheoryMaxMarks { get; set; }

    public string? SubCompulsary { get; set; }

    public DateTime? DateUpdated { get; set; }

    public short? NoOfPapers { get; set; }

    public string? ClassLevel { get; set; }

    public string? ThCode { get; set; }

    public string? Prcode { get; set; }
}
