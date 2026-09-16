using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MasterMenu
{
    public int MenuSrNo { get; set; }

    public short? MenuMainId { get; set; }

    public short? MenuSubId { get; set; }

    public string? MenuMainSubName { get; set; }

    public string? MenuFormLink { get; set; }

    public string? MenuFlag { get; set; }

    public string? MenuModuleName { get; set; }

    public string? MenuImages { get; set; }

    public string? MenuActiveStatus { get; set; }
}
