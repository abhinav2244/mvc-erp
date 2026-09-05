using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Enotesmaster
{
    public int EnotesId { get; set; }

    public string Subject { get; set; } = null!;

    public int EmpId { get; set; }

    public string NotesHeading { get; set; } = null!;

    public string NotesDesc { get; set; } = null!;

    public string AttachmentLink { get; set; } = null!;

    public DateTime Date { get; set; }
}
