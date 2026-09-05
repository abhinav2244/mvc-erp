using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStikerNo
{
    public int Id { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }

    public string? StikerNo { get; set; }

    public bool? IsDelete { get; set; }

    public string? AcadYearId { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? CollegeNameShort { get; set; }
}
