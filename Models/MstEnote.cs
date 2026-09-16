using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstEnote
{
    public int Enid { get; set; }

    public int? EmployeeId { get; set; }

    public int? SubjectCode { get; set; }

    public string? AcadYear { get; set; }

    public string? NotesTopic { get; set; }

    public string? Keywords { get; set; }

    public string? NotesType { get; set; }

    public DateOnly? CreateDate { get; set; }

    public bool? IsDelete { get; set; }
}
