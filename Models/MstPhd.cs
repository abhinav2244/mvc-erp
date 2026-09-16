using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstPhd
{
    public int Phdid { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public string? Topic { get; set; }

    public string? SupervisorName { get; set; }

    public string? UnivInstName { get; set; }

    public string? RegPlace { get; set; }

    public DateOnly? RegDate { get; set; }

    public int? PhdstatusId { get; set; }

    public DateOnly? ExpectedDate { get; set; }

    public short? PaperPubCount { get; set; }

    public DateOnly? CreateDate { get; set; }

    public bool? IsDelete { get; set; }
}
