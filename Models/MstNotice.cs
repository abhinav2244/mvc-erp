using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstNotice
{
    public int NoticeId { get; set; }

    public string? AcadYear { get; set; }

    public int? CreatBy { get; set; }

    public DateOnly? CreatDate { get; set; }

    public string? TopicSubject { get; set; }

    public string? TopicDescription { get; set; }

    public string? AttachmentPath { get; set; }

    public string? RecievedFrom { get; set; }

    public string? ForwardType { get; set; }

    public bool? IsPublish { get; set; }

    public bool? IsDelete { get; set; }
}
