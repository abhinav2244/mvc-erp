using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class CompanyCriterion
{
    public int CriId { get; set; }

    public int CriComId { get; set; }

    public string? CriTenPlusTwo { get; set; }

    public string? CriTentwoAtt { get; set; }

    public string? CriGraDip { get; set; }

    public string? CriGraDipAtt { get; set; }

    public string? CriPostGra { get; set; }

    public string? CriPostGraAtt { get; set; }

    public string? CriVenue { get; set; }

    public DateTime? CriCampusDate { get; set; }

    public string? CriCampusTime { get; set; }

    public string? CriJobCode { get; set; }

    public string? CriJobLocation { get; set; }

    public string? CriCampusProcess { get; set; }

    public string? CriNoOfPost { get; set; }

    public string? CriPostName { get; set; }

    public string? CriCampusType { get; set; }

    public string? CriExperience { get; set; }

    public string? CriOther { get; set; }

    public string? CriRemarks { get; set; }

    public string? CriIsDelete { get; set; }

    public virtual CompanyMaster CriCom { get; set; } = null!;
}
