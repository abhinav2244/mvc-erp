using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CustumReport
{
    public int? Id { get; set; }

    public string? RptId { get; set; }

    public string? AcadYear { get; set; }

    public string? SendRptDate { get; set; }

    public string? SendTo { get; set; }

    public string? Status { get; set; }

    public string? ReportTitle { get; set; }

    public string? Generated { get; set; }

    public string? ReceiveFrom { get; set; }

    public string? UtableName { get; set; }

    public string? UcolumnName { get; set; }
}
