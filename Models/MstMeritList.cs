using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstMeritList
{
    public int Id { get; set; }

    public string? CalssLevel { get; set; }

    public string? Class { get; set; }

    public string? Branch { get; set; }

    public string? Semester { get; set; }

    public DateTime? DateTime { get; set; }

    public int? TotalStudentList { get; set; }

    public bool? IsDelete { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }
}
