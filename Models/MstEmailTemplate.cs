using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstEmailTemplate
{
    public int MstId { get; set; }

    public string? TemplateName { get; set; }

    public string? TemplateCode { get; set; }

    public string? SenderEmailId { get; set; }

    public string? DisplayName { get; set; }

    public string? Password { get; set; }

    public string? Subject { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDelete { get; set; }

    public string? EmailMessage { get; set; }
}
