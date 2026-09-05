using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class WorkSheet
{
    public long WsId { get; set; }

    public int? WorkByEmpId { get; set; }

    public int? WorkToEmpId { get; set; }

    public string? WsSubject { get; set; }

    public string? WsWork { get; set; }

    public string? Attachment { get; set; }

    public DateTime? WsDateTime { get; set; }

    public string? Status { get; set; }
}
