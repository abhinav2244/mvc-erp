using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstUgcrecognition
{
    public int Id { get; set; }

    public string? UnderSection { get; set; }

    public DateOnly? RecognitionDate { get; set; }

    public string? DocumentPath { get; set; }
}
