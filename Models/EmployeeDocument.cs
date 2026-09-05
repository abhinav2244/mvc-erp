using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class EmployeeDocument
{
    public int DocId { get; set; }

    public int EmpId { get; set; }

    public string? DocType { get; set; }

    public string? DocLocation { get; set; }
}
