using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstStudentMdmbasket
{
    public int Sbid { get; set; }

    public int? StudId { get; set; }

    public int? StudBranchCode { get; set; }

    public int? BucketId { get; set; }

    public int? MdmbranchCode { get; set; }

    public string? StudAcadYear { get; set; }
}
