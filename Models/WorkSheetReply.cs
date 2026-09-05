using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class WorkSheetReply
{
    public int WsrId { get; set; }

    public int? WsId { get; set; }

    public int? ReplyByEmpId { get; set; }

    public string? RplWork { get; set; }

    public DateTime? RplDateTime { get; set; }

    public string? Status { get; set; }
}
