using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HStudentHscsscpassDetail
{
    public int SrNo { get; set; }

    public int? StudSrNo { get; set; }

    public string? ObtainMarks { get; set; }

    public string? OutOfMarks { get; set; }

    public string? Flag { get; set; }

    public bool? IsDelete { get; set; }

    public string? SubjectName { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }
}
