using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Rginfo
{
    public int RegId { get; set; }

    public int? StudId { get; set; }

    public DateTime? RegDate { get; set; }

    public DateTime? Apvdate { get; set; }
}
