using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BillDeskMerchantDetail
{
    public int MerDtlId { get; set; }

    public string? MerchantId { get; set; }

    public string? SecurityId { get; set; }

    public string? Mid { get; set; }

    public string? ChecksumKey { get; set; }

    public string? MerchantName { get; set; }

    public string? MerchantChildId { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? BeneficiaryBankName { get; set; }

    public string? BeneficiaryBankAcno { get; set; }

    public string? BeneficiaryIfsc { get; set; }

    public bool? IsActive { get; set; }
}
