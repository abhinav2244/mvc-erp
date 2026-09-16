using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class RegistrationInfo
{
    public int RegId { get; set; }

    public string? RegName { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public DateTime? RegistrationDateTime { get; set; }

    public string? RegRequestFromIp { get; set; }

    public bool? IsActive { get; set; }

    public string? MarkAsDeleted { get; set; }

    public int? CategoryId { get; set; }

    public string? UserName { get; set; }

    public int? CollegeId { get; set; }

    public int? DeptId { get; set; }

    public int? DesgId { get; set; }

    public string? EmpCode { get; set; }

    public string? ClgAddress { get; set; }

    public int? Studentid { get; set; }
}
