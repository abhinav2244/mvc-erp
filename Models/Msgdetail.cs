using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Msgdetail
{
    public int? MsgId { get; set; }

    public int? ParentId { get; set; }

    public string? HeaderStr { get; set; }

    public string? DetailStr { get; set; }

    public string? AuthorNameStr { get; set; }

    public string? AuthorEmailStr { get; set; }

    public string? AuthorUrlStr { get; set; }

    public DateTime? MsgTime { get; set; }
}
