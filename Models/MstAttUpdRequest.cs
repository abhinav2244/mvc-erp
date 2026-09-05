using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAttUpdRequest
{
    public int Id { get; set; }

    public int? Ttid { get; set; }

    public DateOnly? AttendanceDate { get; set; }

    public bool? RequestStatus { get; set; }

    public DateOnly? RequestDate { get; set; }

    public DateOnly? ResponseDate { get; set; }
}
