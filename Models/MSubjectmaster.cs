using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MSubjectmaster
{
    public int? SubjectCode { get; set; }

    public string? SubjectAbbr { get; set; }

    public string? SubjectName { get; set; }

    public string? SubjectPractical { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public string? SubCompulsary { get; set; }

    public string? ClassLevel { get; set; }
}
