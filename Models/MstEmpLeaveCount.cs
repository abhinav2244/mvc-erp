using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstEmpLeaveCount
{
    public int Elcid { get; set; }

    public string? AcadYear { get; set; }

    public int EmployeeId { get; set; }

    public int Ltid { get; set; }

    public string? MaxLeave { get; set; }
}
