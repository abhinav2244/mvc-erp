using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HAdmissionUsingStikerNo
{
    public int AdmissionId { get; set; }

    public int? StudId { get; set; }

    public string? StudAcadYear { get; set; }

    public string? StikerNo { get; set; }

    public DateTime? AdmissionDateTime { get; set; }
}
