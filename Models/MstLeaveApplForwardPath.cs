using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstLeaveApplForwardPath
{
    public int Fpid { get; set; }

    public int CatId { get; set; }

    public int? PreCatId { get; set; }

    public int CurrentCatId { get; set; }

    public int? NextCatId { get; set; }

    public short ForwardSequence { get; set; }
}
