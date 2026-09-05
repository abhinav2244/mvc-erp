using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HStudentGroupPreference
{
    public int Id { get; set; }

    public int? StudSrNo { get; set; }

    public int? PreferenceN0 { get; set; }

    public string? GroupName { get; set; }

    public bool? IsDelete { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }
}
