using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstFaculty
{
    public int FacultyId { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsSync { get; set; }
}
