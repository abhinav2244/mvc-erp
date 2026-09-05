using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Tempsubject
{
    public int? Sno { get; set; }

    public string? ClassId { get; set; }

    public string? StudSemester { get; set; }

    public string? Medium { get; set; }

    public string? Sname { get; set; }

    public string? Sname1 { get; set; }

    public string? Initials { get; set; }

    public string? SubjectAbbr { get; set; }

    public string? SubjectName { get; set; }

    public string? Faculty { get; set; }

    public DateTime? StudAdmissionDate { get; set; }

    public DateTime? StudBirthDate { get; set; }

    public string? StudCaste { get; set; }

    public string? Category { get; set; }

    public string? Classlevel { get; set; }

    public string? StudAcadYear { get; set; }

    public int? StudId { get; set; }

    public int? AdmFormNo { get; set; }
}
