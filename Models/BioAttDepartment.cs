using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BioAttDepartment
{
    public int DepartmentId { get; set; }

    public string DepartmentFname { get; set; } = null!;

    public string DepartmentSname { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int RecordStatus { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string C3 { get; set; } = null!;

    public string C4 { get; set; } = null!;

    public string C5 { get; set; } = null!;

    public string C6 { get; set; } = null!;

    public string C7 { get; set; } = null!;
}
