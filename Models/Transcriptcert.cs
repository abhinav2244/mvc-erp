using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Transcriptcert
{
    public string? ClassId { get; set; }

    public string? Branch { get; set; }

    public string? Semester { get; set; }

    public string? StudName { get; set; }

    public string? SubjectName { get; set; }

    public int? Months { get; set; }

    public int? Lecture { get; set; }

    public int? Lab { get; set; }

    public double? CreditHrs { get; set; }

    public short? MarksObt { get; set; }

    public int? MaxMarks { get; set; }

    public double? MarkPercent { get; set; }

    public double? EquiGpa { get; set; }

    public double? Credit { get; set; }

    public string? Other { get; set; }

    public string? FromSession { get; set; }

    public string? ToSession { get; set; }

    public string? MarksheetNo { get; set; }

    public DateTime? IssueDate { get; set; }

    public string? RollNo { get; set; }

    public string? Session { get; set; }
}
