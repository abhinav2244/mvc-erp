using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CompanyMaster
{
    public int ComId { get; set; }

    public string? ComCode { get; set; }

    public string? ComType { get; set; }

    public string? ComName { get; set; }

    public string? ComCity { get; set; }

    public string? ComAddress { get; set; }

    public long? ComPhNo { get; set; }

    public long? ComFax { get; set; }

    public string? ComPlatForm { get; set; }

    public string? ComWebSite { get; set; }

    public string? ComEmailId { get; set; }

    public string? ComHrName { get; set; }

    public long? ComHrPhNo { get; set; }

    public long? ComHrFax { get; set; }

    public string? ComHrEmailId { get; set; }

    public string? ComIsDelete { get; set; }

    public virtual ICollection<CompanyCriterion> CompanyCriteria { get; set; } = new List<CompanyCriterion>();
}
