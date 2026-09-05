using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstPaperSetter
{
    public int Psid { get; set; }

    public int? BranchCode { get; set; }

    public string? Class { get; set; }

    public string? Semester { get; set; }

    public string? AcadYear { get; set; }

    public int? AssessmentId { get; set; }

    public string? SubjectCode { get; set; }

    public int? SetterEmpId { get; set; }

    public int? ModeratorEmpId { get; set; }

    public DateOnly? PsetDate { get; set; }

    public DateOnly? SelectionDate { get; set; }

    public bool? IsSelected { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsSubmit { get; set; }

    public string? Remarks { get; set; }
}
