using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExternalTeacher
{
    public int TeacherId { get; set; }

    public string TeacherName { get; set; } = null!;

    public string EmpUserId { get; set; } = null!;

    public long MobileNumber { get; set; }

    public string EmailId { get; set; } = null!;

    public string CollegeName { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string? Specialization { get; set; }

    public string? Qualification { get; set; }

    public string Experience { get; set; } = null!;
}
