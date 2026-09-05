using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QScholarshipsDetail
{
    public int StudId { get; set; }

    public string? StudTitle { get; set; }

    public string? StudFirstName { get; set; }

    public string? StudMiddleName { get; set; }

    public string? StudLastName { get; set; }

    public string? StudSex { get; set; }

    public string? StudCommunityId { get; set; }

    public string? Caste { get; set; }

    public string? StudAcadYear { get; set; }

    public string? ClassLevel { get; set; }

    public string? StudClass { get; set; }

    public string? StudSemester { get; set; }

    public string? StudSection { get; set; }

    public int? BranchCode { get; set; }

    public string? BranchAbbr { get; set; }

    public string? BranchName { get; set; }

    public string? ScholarshipStatus { get; set; }

    public string? BankName { get; set; }

    public string? AccountNo { get; set; }

    public double? StudFeePayable { get; set; }

    public double StudFeePaid { get; set; }

    public double AmountRefund { get; set; }

    public string? StudStatus { get; set; }

    public string? BillNo { get; set; }
}
