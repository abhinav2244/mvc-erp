using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HStudPhoto
{
    public int StudPhotoId { get; set; }

    public int? StudSrNo { get; set; }

    public byte[]? StudPhoto { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }
}
