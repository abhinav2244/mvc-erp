using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstCollege
{
    public int CollegeId { get; set; }

    public string? CollegeCode { get; set; }

    public string? CollegeName { get; set; }

    public bool? IsActive { get; set; }

    public byte[]? LogoCollege { get; set; }

    public byte[]? PrincipalSignature { get; set; }
}
