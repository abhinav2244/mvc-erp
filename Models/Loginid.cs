using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Loginid
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? Userlogin { get; set; }

    public string? Password1 { get; set; }

    public string? Confirmpassword1 { get; set; }

    public string? Specategory { get; set; }

    public int? Idnumber { get; set; }

    public string? ClassLevel { get; set; }

    public bool? IsLock { get; set; }
}
