using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentAttendanceDetail
{
    public int? Samid { get; set; }

    public int? StudId { get; set; }

    public string? StudRollNo { get; set; }

    public string? OriginalStatus { get; set; }

    public string? ModifiedStatus { get; set; }
}
