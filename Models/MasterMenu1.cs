using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MasterMenu1
{
    public int SrNo { get; set; }

    public short? MainId { get; set; }

    public short? SubId { get; set; }

    public string? MainSubName { get; set; }

    public string? FormLink { get; set; }

    public string? Flag { get; set; }

    public string? ModuleName { get; set; }

    public string? Image { get; set; }
}
