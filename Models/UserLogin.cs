using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class UserLogin
{
    public int LoginId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool? IsLogin { get; set; }

    public DateTime? FirstLoginDateTime { get; set; }

    public int? CategoryId { get; set; }

    public int? RegId { get; set; }
}
