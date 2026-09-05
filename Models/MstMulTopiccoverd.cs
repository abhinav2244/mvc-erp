using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstMulTopiccoverd
{
    public int Tcid { get; set; }

    public int? Samid { get; set; }

    public int? Elaid { get; set; }

    public int? TopicId { get; set; }

    public bool? IsDelete { get; set; }
}
