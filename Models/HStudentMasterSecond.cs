using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HStudentMasterSecond
{
    public int Hssid { get; set; }

    public int? Studid { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public DateTime? Dob { get; set; }

    public string? Mobile { get; set; }

    public string? Emailid { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Pincode { get; set; }

    public string? OldAcadYear { get; set; }

    public string? OldClasslevel { get; set; }

    public string? OldClass { get; set; }

    public string? OldBranchcode { get; set; }

    public string? OldSemester { get; set; }

    public string? OldStudStatus { get; set; }

    public string? Section { get; set; }

    public string? AdmnType { get; set; }

    public string? AdmnMode { get; set; }

    public string? StudType { get; set; }

    public string? NewAcadYear { get; set; }

    public string? NewClasslevel { get; set; }

    public string? NewClass { get; set; }

    public string? NewBranchcode { get; set; }

    public string? NewSemester { get; set; }

    public string? AppStatus { get; set; }

    public DateTime? AppStatusUpdateDate { get; set; }

    public DateTime? AppDate { get; set; }

    public bool? Isdelete { get; set; }
}
