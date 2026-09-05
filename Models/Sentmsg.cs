using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Sentmsg
{
    public int? Id { get; set; }

    public string? Sender { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public string? SendDate { get; set; }

    public string? SendTo { get; set; }

    public string? Attach { get; set; }

    public string? IsDel { get; set; }

    public string? IsRead { get; set; }

    public string? Userfullname { get; set; }

    public string? Attachorg { get; set; }
}
