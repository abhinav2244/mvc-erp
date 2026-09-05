using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class UserWorkAssignOld
{
    public int Id { get; set; }

    public string? UserLogin { get; set; }

    public string? Password1 { get; set; }

    public short? MainId { get; set; }

    public short? SubId { get; set; }

    public string? FormName { get; set; }

    public string? FormLink { get; set; }

    public string? Flag { get; set; }

    public string? AuthBy { get; set; }

    public string? ModuleName { get; set; }

    public string? Image { get; set; }
}
