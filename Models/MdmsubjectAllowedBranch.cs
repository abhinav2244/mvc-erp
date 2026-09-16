using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MdmsubjectAllowedBranch
{
    public int SessionId { get; set; }

    public int SubjectCode { get; set; }

    public string AllowedBranchCode { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public virtual MdmsubjectSession MdmsubjectSession { get; set; } = null!;
}
