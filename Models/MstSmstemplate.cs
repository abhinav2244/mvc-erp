using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstSmstemplate
{
    public int MstId { get; set; }

    public string? TemplateName { get; set; }

    public string? TemplateId { get; set; }

    public string? EntityId { get; set; }

    public string? SenderId { get; set; }

    public string? Route { get; set; }

    public string? Uname { get; set; }

    public string? Pwd { get; set; }

    public string? Api { get; set; }

    public string? Flag { get; set; }

    public string? Other1 { get; set; }

    public string? Other2 { get; set; }

    public string? Other3 { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDelete { get; set; }

    public string? Smsmessage { get; set; }

    public string? TemplateCode { get; set; }
}
