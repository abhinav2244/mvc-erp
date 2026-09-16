using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class LibDbCon
{
    public int Id { get; set; }

    public string? Srvrdbname { get; set; }

    public string? Srvrname { get; set; }

    public string? Srvrusername { get; set; }

    public string? Srvrpassword { get; set; }
}
