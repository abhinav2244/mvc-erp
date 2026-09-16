using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HStudentSubjectDetail
{
    public int SubSrNo { get; set; }

    public int? StudSrNo { get; set; }

    public string? SubjectCode { get; set; }

    public string? Flag { get; set; }

    public bool? IsDelete { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }

    public int? Typeid { get; set; }

    public virtual HStudentMaster? StudSrNoNavigation { get; set; }
}
