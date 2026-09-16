using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstSubjectTeacher
{
    public int? SubjectCode { get; set; }

    public int? EmployeeId { get; set; }

    public string? ThPrType { get; set; }

    public string? Section { get; set; }
}
