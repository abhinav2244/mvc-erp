using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QuestionTable
{
    public int Id { get; set; }

    public string? QueId { get; set; }

    public string? FacultyId { get; set; }

    public string? Emark { get; set; }

    public string? AssgNo { get; set; }

    public string? Qtype { get; set; }

    public string? Subject { get; set; }

    public string? Title { get; set; }
}
