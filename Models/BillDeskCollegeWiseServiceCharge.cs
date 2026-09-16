using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskCollegeWiseServiceCharge
{
    public int Scid { get; set; }

    public int? CollegeCode { get; set; }

    public decimal? Scamount { get; set; }

    public bool? IsDelete { get; set; }
}
