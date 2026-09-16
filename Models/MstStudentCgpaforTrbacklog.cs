using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStudentCgpaforTrbacklog
{
    public int? StudId { get; set; }

    public string? EnrollmentNumber { get; set; }

    public string? Rollnumber { get; set; }

    public string? Semester { get; set; }

    public double? SumOfGradeObtained { get; set; }

    public double? SumOfCreditPoints { get; set; }

    public double? Cgpa { get; set; }

    public int? BackExamId { get; set; }
}
