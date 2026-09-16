using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Examinstruction
{
    public int PhotoId { get; set; }

    public string? ImgPath { get; set; }

    public DateTime? UploadedDate { get; set; }

    public int? UploaderId { get; set; }
}
