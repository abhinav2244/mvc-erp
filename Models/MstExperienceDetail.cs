using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstExperienceDetail
{
    public int ExpId { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public string? IndTeachExp { get; set; }

    public string? OrganizationName { get; set; }

    public string? Designation { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Description { get; set; }

    public string? Present { get; set; }

    public DateOnly? CreatDate { get; set; }

    public bool? IsDelete { get; set; }

    public string? UploadedPhoto { get; set; }
}
