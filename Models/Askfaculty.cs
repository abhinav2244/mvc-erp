using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Askfaculty
{
    public int Id { get; set; }

    public long? Studid { get; set; }

    public string? TeacherName { get; set; }

    public string? Question { get; set; }

    public string? Subject { get; set; }

    public byte[]? ImageBlob { get; set; }

    public string? Filename { get; set; }

    public int? Length { get; set; }

    public string? Postdate { get; set; }

    public string? GetReply { get; set; }

    public string? AcadYear { get; set; }

    public int? AnsNo { get; set; }
}
