using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Tcdetail
{
    public int Id { get; set; }

    public int? StudId { get; set; }

    public string? StudentName { get; set; }

    public DateTime? Tcdate { get; set; }

    public string? FirstDuplicate { get; set; }

    public string? AppReceived { get; set; }

    public DateTime? AppDate { get; set; }

    public string? StudentStatus { get; set; }

    public string? FeesBalance { get; set; }

    public string? AcadYear { get; set; }

    public DateTime? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? ClassLevel { get; set; }

    public int? TcNo { get; set; }

    public string? RegisterNo { get; set; }

    public string? Class { get; set; }

    public string? Branch { get; set; }

    public string? Title { get; set; }

    public string? TcIsIssued { get; set; }

    public string? TcRemark3 { get; set; }

    public DateTime? TcSesFrom { get; set; }

    public DateTime? TcSesTo { get; set; }

    public string? TcReason { get; set; }

    public string? TcResult { get; set; }

    public string? TcDuration { get; set; }

    public string? TcConduct { get; set; }

    public string? TcProgress { get; set; }

    public bool? TcIsCancle { get; set; }

    public string? TcCancelReason { get; set; }
}
