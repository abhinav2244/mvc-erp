using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStudentCgpaforTr
{
    public int? StudId { get; set; }

    public string? EnrollmentNumber { get; set; }

    public string? Rollnumber { get; set; }

    public double? SumOfGradeObtained { get; set; }

    public double? SumOfCreditPoints { get; set; }

    public double? Cgpa { get; set; }
}
