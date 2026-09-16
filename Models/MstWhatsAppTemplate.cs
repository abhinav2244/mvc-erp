using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstWhatsAppTemplate
{
    public int MstId { get; set; }

    public string? TemplateName { get; set; }

    public string TemplateCode { get; set; } = null!;

    public string Uname { get; set; } = null!;

    public string Pwd { get; set; } = null!;

    public string WhatsAppNo { get; set; } = null!;

    public string Apiurl { get; set; } = null!;

    public string Apikey { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDelete { get; set; }

    public string WhatsAppMessage { get; set; } = null!;
}
