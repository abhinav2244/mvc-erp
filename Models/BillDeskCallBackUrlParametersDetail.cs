using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskCallBackUrlParametersDetail
{
    public int ClUrlId { get; set; }

    public int? OrderId { get; set; }

    public string? TxnId { get; set; }

    public string? StudSrNo { get; set; }

    public string? Flag { get; set; }

    public string? Logtype { get; set; }

    public string? ChatUsername { get; set; }

    public string? CurrAcadYear { get; set; }

    public string? UserName { get; set; }

    public string? BranchId { get; set; }

    public string? FeesSrnoId { get; set; }

    public string? UserLogId { get; set; }

    public string? Remark { get; set; }

    public bool? Isdelete { get; set; }
}
