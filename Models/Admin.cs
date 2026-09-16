using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Admin
{
    public string? AdministratorName { get; set; }

    public string? Pass { get; set; }

    public string? ConfirmPassword { get; set; }
}
