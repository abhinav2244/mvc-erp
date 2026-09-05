using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstCollegeBankAccount
{
    public int ClgBnkId { get; set; }

    public int? CollegeCode { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? AccType { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? BankName { get; set; }

    public string? Branch { get; set; }

    public string? BankAddress { get; set; }

    public string? CollegeAccNo { get; set; }

    public string? Ifscno { get; set; }

    public string? Pgmercid { get; set; }

    public string? Mercid { get; set; }

    public bool? IsActive { get; set; }

    public int? RptBookNo { get; set; }

    public bool? IsNewBillDesk { get; set; }
}
