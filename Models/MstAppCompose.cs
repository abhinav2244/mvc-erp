using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAppCompose
{
    public int ComId { get; set; }

    public string? ComCode { get; set; }

    public string? ComInfo { get; set; }

    public string? ComSubject { get; set; }

    public string? ComIsDeleted { get; set; }
}
