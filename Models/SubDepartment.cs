using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class SubDepartment
{
    public int SubDepartmentId { get; set; }

    public string DepartmentId { get; set; } = null!;

    public string SubDepartmentName { get; set; } = null!;
}
