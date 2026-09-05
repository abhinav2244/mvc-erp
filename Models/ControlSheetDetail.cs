using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ControlSheetDetail
{
    public int ControlSheetDetailsId { get; set; }

    public int? ControlSheetId { get; set; }

    public int? FolioNo { get; set; }

    public int? ExamFormId { get; set; }

    public int? RollNumber { get; set; }

    public int? ControlSheetNo { get; set; }

    public int? ControlSheetPageNo { get; set; }

    public int? ControlSheetFolioNo { get; set; }

    public int? ControlSheetPageSrNo { get; set; }

    public int? ControlSheetSrNo { get; set; }
}
