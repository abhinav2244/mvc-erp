using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Departmentmaster
{
    public string? SchoolId { get; set; }

    public string DepartmentId { get; set; } = null!;

    public string? DepartmentName { get; set; }

    public string? FacultyId { get; set; }

    public DateTime? DateUpdated { get; set; }

    public string? ClassLevel { get; set; }

    public int? BranchCode { get; set; }
}
