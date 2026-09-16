using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamBarcode
{
    public int Id { get; set; }

    public int ExamFormId { get; set; }

    public int ExamId { get; set; }

    public int ExamYearId { get; set; }

    public byte[] BarcodeImage { get; set; } = null!;
}
