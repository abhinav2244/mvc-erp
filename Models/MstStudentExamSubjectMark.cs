using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStudentExamSubjectMark
{
    public int ExamSubjectId { get; set; }

    public int? ExamMarksId { get; set; }

    public int? SubjectCode { get; set; }

    public string? Subject { get; set; }

    public double? SubjectObtainMarks { get; set; }

    public double? SubjectTotalMarks { get; set; }

    public double? SubjectPercentage { get; set; }

    public double? SubjectSgpa { get; set; }
}
