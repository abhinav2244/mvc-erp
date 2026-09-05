using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstCourse
{
    public int Id { get; set; }

    public string? ClassLevel { get; set; }

    public string? CourseAbbr { get; set; }

    public string? CourseName { get; set; }

    public short? CourseDurationInMonth { get; set; }

    public string? EntryQualification { get; set; }

    public string? CourseMedium { get; set; }

    public short? SanctionedStrength { get; set; }
}
