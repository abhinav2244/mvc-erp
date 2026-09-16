using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstOption
{
    public short OptionId { get; set; }

    public string? OptionA { get; set; }

    public string? OptionB { get; set; }

    public string? OptionC { get; set; }

    public string? OptionD { get; set; }

    public string? OptionE { get; set; }

    public short? OptionAvalue { get; set; }

    public short? OptionBvalue { get; set; }

    public short? OptionCvalue { get; set; }

    public short? OptionDvalue { get; set; }

    public short? OptionEvalue { get; set; }

    public short? TotalOption { get; set; }
}
