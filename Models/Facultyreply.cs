using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Facultyreply
{
    public int? Id { get; set; }

    public string? Studid { get; set; }

    public string? TeacherName { get; set; }

    public string? QuesReply { get; set; }

    public byte[]? ImageBlob { get; set; }

    public string? FileName { get; set; }

    public int? Length { get; set; }

    public string? Postdate { get; set; }

    public string? GetReply { get; set; }

    public string? AcadYear { get; set; }

    public int? Qno { get; set; }

    public string Tag { get; set; } = null!;
}
