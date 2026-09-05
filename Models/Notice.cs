using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Notice
{
    public int? NoticeId { get; set; }

    public DateTime? NoticeDate { get; set; }

    public string? Notice1 { get; set; }

    public string? NoticeFrom { get; set; }

    public string? Title { get; set; }

    public string? NoticeTo { get; set; }

    public string? NoticeStatus { get; set; }

    public string? NoticeUrl { get; set; }
}
