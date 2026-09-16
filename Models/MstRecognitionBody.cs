using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstRecognitionBody
{
    public int Id { get; set; }

    public string? Authority { get; set; }

    public string? AuthorityDetails { get; set; }

    public DateOnly? RecognitionDate { get; set; }

    public short? ValidityInMonth { get; set; }

    public string? Remarks { get; set; }
}
