using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class AppAuthorization
{
    public int AuthAppId { get; set; }

    public string? AuthAppCode { get; set; }

    public int? AuthEmpId { get; set; }

    public DateTime? AuthDate { get; set; }

    public string? AuthTo { get; set; }

    public string? AuthDepartmentId { get; set; }

    public string? AuthForwardTo { get; set; }

    public string? AuthPermission { get; set; }

    public string? AuthActTakenBy { get; set; }

    public string? AuthReason { get; set; }

    public string? AuthIsDelete { get; set; }

    public string? AuthIsPrint { get; set; }
}
