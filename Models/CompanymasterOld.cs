using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CompanymasterOld
{
    public int Id { get; set; }

    public string Departmentname { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Companyaddress { get; set; }

    public string? Criteria1 { get; set; }

    public string? Criteria2 { get; set; }

    public DateTime Campusdate { get; set; }

    public string? Joblocation { get; set; }

    public string? JobDescription { get; set; }

    public string? Venue { get; set; }

    public string? WebSiteAddress { get; set; }

    public string? Emailaddress { get; set; }

    public string? Experience { get; set; }

    public string? Acadyear { get; set; }

    public string? NoPosts { get; set; }

    public string? PostName { get; set; }

    public string? InterviewType { get; set; }

    public string? Classlevel { get; set; }

    public string? Companyid { get; set; }

    public string? Branchcode { get; set; }

    public string? Session { get; set; }

    public string? StudClass { get; set; }

    public string? CompanyType { get; set; }
}
