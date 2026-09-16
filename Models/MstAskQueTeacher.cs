using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAskQueTeacher
{
    public int Aqtid { get; set; }

    public int? StudId { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public int? SubjectCode { get; set; }

    public int? TeacherId { get; set; }

    public string? Question { get; set; }

    public string? FilePath { get; set; }

    public DateOnly? CreateDate { get; set; }

    public bool? AnsStatus { get; set; }

    public string? AcadYear { get; set; }

    public int? AnsId { get; set; }

    public bool? IsDelete { get; set; }
}
