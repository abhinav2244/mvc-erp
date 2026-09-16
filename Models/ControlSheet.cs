using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ControlSheet
{
    public int ControlSheetId { get; set; }

    public int? ControlSheetNo { get; set; }

    public int? SerialNo { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamSubjectId { get; set; }

    public string? PaperThPr { get; set; }

    public int? MediumId { get; set; }

    public int? TotalNoOfCandidates { get; set; }

    public string? PaperIntext { get; set; }

    public bool? IsSubmitted { get; set; }
}
