using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStaffQualificationDetail
{
    public int Id { get; set; }

    public string? StaffType { get; set; }

    public string? ClassLevel { get; set; }

    public short? CategoryId { get; set; }

    public short? Male { get; set; }

    public short? Female { get; set; }

    public short? Other { get; set; }

    public short? Total { get; set; }
}
