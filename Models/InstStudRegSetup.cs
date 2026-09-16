using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class InstStudRegSetup
{
    public int IsrsId { get; set; }

    public string? Collegecode { get; set; }

    public string? PaymentType { get; set; }

    public bool? IsRegCharge { get; set; }

    public float? RegCharge { get; set; }

    public int? RegBankId { get; set; }

    public string? PaymentGateway { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsPaymentTimeCondition { get; set; }

    public DateTime? PaymentStartTime { get; set; }

    public DateTime? PaymentEndTime { get; set; }

    public string? ClassLevel { get; set; }
}
