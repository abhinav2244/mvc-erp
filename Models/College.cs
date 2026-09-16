using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class College
{
    public int CollegeId { get; set; }

    public string? CollegeCode { get; set; }

    public string? CollegeTitle { get; set; }

    public string? CollegeName { get; set; }

    public string? DistrictTaluka { get; set; }

    public string? CollegeDiv { get; set; }

    public string? CollegeGrantFlag { get; set; }

    public string? CollSchHigFlag { get; set; }
}
