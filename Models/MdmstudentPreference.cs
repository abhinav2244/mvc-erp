using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MdmstudentPreference
{
    public int PreferenceId { get; set; }

    public int SessionId { get; set; }

    public int StudentId { get; set; }

    public int PreferenceNo { get; set; }

    public int SubjectCode { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public decimal? Cetscore { get; set; }

    public decimal? Sgpascore { get; set; }

    public bool IsActive { get; set; }

    public bool IsLocked { get; set; }

    public int? LastModifiedBy { get; set; }

    public bool? IsOpen { get; set; }
}
