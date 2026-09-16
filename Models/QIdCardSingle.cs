using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QIdCardSingle
{
    public int StudId { get; set; }

    public string? StudName { get; set; }

    public DateTime? Dob { get; set; }

    public string? Phone { get; set; }

    public string? StudClass { get; set; }

    public string? Bloodgroup { get; set; }

    public string? ClassLevel { get; set; }

    public string? StudSection { get; set; }

    public string? StudAcadYear { get; set; }

    public string? Branch { get; set; }

    public string? EnrollNo { get; set; }

    public string? Emailid { get; set; }

    public byte[]? Photo { get; set; }

    public string? LocalAddress { get; set; }

    public string? StudUserName { get; set; }

    public string? FatherMobile { get; set; }

    public string? Status { get; set; }

    public string? StudSemester { get; set; }

    public string? BranchName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }
}
