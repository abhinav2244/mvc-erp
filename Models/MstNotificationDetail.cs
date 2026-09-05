using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstNotificationDetail
{
    public int Ndid { get; set; }

    public string NotificationType { get; set; } = null!;

    public string TemplateCode { get; set; } = null!;

    public DateTime NotificationDate { get; set; }

    public string? SendToMobileNo { get; set; }

    public string? SendToEmailId { get; set; }

    public string NotificationStatus { get; set; } = null!;

    public string? MessageId { get; set; }
}
