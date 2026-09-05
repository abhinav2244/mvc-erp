using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstPaperPublication
{
    public int PubId { get; set; }

    public int? EmployeeId { get; set; }

    public string? AcadYear { get; set; }

    public string? Title { get; set; }

    public string? Name { get; set; }

    public int? LevelType { get; set; }

    public int? VolumeNo { get; set; }

    public DateOnly? VolDate { get; set; }

    public int? Pages { get; set; }

    public string? PublicNo { get; set; }

    public DateOnly? PublicDate { get; set; }

    public string? PaperLink { get; set; }

    public DateOnly? CreateDate { get; set; }

    public bool? IsDelete { get; set; }

    public string? UploadedDocument { get; set; }
}
