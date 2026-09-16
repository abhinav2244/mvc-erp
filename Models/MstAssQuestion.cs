using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAssQuestion
{
    public int QueId { get; set; }

    public string? QueType { get; set; }

    public int? TeacherId { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public int? SubjectCode { get; set; }

    public string? Question { get; set; }

    public string? QueAns { get; set; }

    public string? QueAnsImagePath { get; set; }

    public string? OptionA { get; set; }

    public string? OptionB { get; set; }

    public string? OptionC { get; set; }

    public string? OptionD { get; set; }

    public string? OptionE { get; set; }

    public string? OptionAns { get; set; }

    public bool? IsDelete { get; set; }
}
