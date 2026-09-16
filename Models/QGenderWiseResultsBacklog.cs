using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QGenderWiseResultsBacklog
{
    public int? ExamId { get; set; }

    public int? ExamYearId { get; set; }

    public int TotalStudents { get; set; }

    public int MaleAppeared { get; set; }

    public int FemaleAppeared { get; set; }

    public int MalePass { get; set; }

    public int MaleFail { get; set; }

    public int FemalePass { get; set; }

    public int FemaleFail { get; set; }
}
