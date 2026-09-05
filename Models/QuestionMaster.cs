using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QuestionMaster
{
    public int QueId { get; set; }

    public string? DepartmentId { get; set; }

    public string? Semester { get; set; }

    public string? Subject { get; set; }

    public string? Question { get; set; }

    public string? Qtype { get; set; }

    public string? Option1 { get; set; }

    public string? Option2 { get; set; }

    public string? Option3 { get; set; }

    public string? Option4 { get; set; }

    public string? Answer { get; set; }

    public string? Attachment { get; set; }

    public string? FacultyId { get; set; }

    public string? Assgno { get; set; }

    public int? SubCodeId { get; set; }

    public string? QueAuthBy { get; set; }

    public string? Authorize { get; set; }
}
