using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TeacherQualification
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public string? QualificationCode { get; set; }

    public string? DegreeType { get; set; }

    public string? College { get; set; }

    public string? UniversityCode { get; set; }

    public int? YearOfPassing { get; set; }

    public string? Branch { get; set; }

    public virtual MasterTeacherInfo? Employee { get; set; }
}
