using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ControlSheetCtable
{
    public int CtableEntryId { get; set; }

    public int? ExamFormId { get; set; }

    public int? OldexamSubjectId { get; set; }

    public int? ExamSubjectId { get; set; }

    public int? ControlSheetNoThinternal { get; set; }

    public int? ControlSheetNoThexternal { get; set; }

    public int? ControlSheetNoPrinternal { get; set; }

    public int? ControlSheetNoPrexternal { get; set; }

    public int? ObtMarksThinternal { get; set; }

    public int? ObtMarksThexternal { get; set; }

    public int? ObtMarksPrinternal { get; set; }

    public int? ObtMarksPrexternal { get; set; }

    public bool IsdeleteCt { get; set; }
}
