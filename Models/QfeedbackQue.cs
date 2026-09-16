using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QfeedbackQue
{
    public int? TeacherName { get; set; }

    public string? Subject { get; set; }

    public string? DepartmentName { get; set; }

    public decimal? SumOfTotal { get; set; }

    public int? CountOfTotal { get; set; }

    public decimal? Pindex { get; set; }

    public string Remarks { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public int? SumOfQsa1 { get; set; }

    public int? SumOfQsb1 { get; set; }

    public int? SumOfQsc1 { get; set; }

    public int? SumOfQsd1 { get; set; }

    public int? SumOfQse1 { get; set; }

    public int? SumOfQsf1 { get; set; }

    public int? SumOfQsg1 { get; set; }

    public int? SumOfQsh1 { get; set; }

    public int? SumOfQsi1 { get; set; }

    public int? SumOfQsj1 { get; set; }

    public int? SumOfQsk1 { get; set; }

    public int? SumOfQsl1 { get; set; }

    public int? SumOfQsm { get; set; }

    public string? Acadyear { get; set; }
}
