using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CustumRptMaster
{
    public int? Id { get; set; }

    public string? RptId { get; set; }

    public string? RptFields1 { get; set; }

    public string? RptFields2 { get; set; }

    public int? Rptcol1 { get; set; }

    public int? Rptcol2 { get; set; }

    public string? Notes { get; set; }
}
