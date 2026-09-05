using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Designationmaster
{
    public string? CompanyId { get; set; }

    public string? DesignationId { get; set; }

    public string? DesignationName { get; set; }

    public string? TeachingType { get; set; }

    public string? AcademicYear { get; set; }

    public DateTime? DateUpdated { get; set; }

    public short? SeniorityOrder { get; set; }

    public string? ClassLevel { get; set; }
}
