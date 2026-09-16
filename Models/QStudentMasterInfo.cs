using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QStudentMasterInfo
{
    public int StudId { get; set; }

    public string? Prn { get; set; }

    public string? EnrollmentNo { get; set; }

    public byte[] Logo { get; set; } = null!;

    public string? Trust { get; set; }

    public string? Institute { get; set; }

    public string? InstiAdd { get; set; }

    public string? Place { get; set; }

    public byte[]? StudPhoto { get; set; }

    public string? StudName { get; set; }

    public string? FatherName { get; set; }

    public string? StudMotherName { get; set; }

    public string? FatherOccupiation { get; set; }

    public string Gender { get; set; } = null!;

    public string? BirthDate { get; set; }

    public string? BloodGp { get; set; }

    public string? Phone { get; set; }

    public string? EmailId { get; set; }

    public string? Laddress { get; set; }

    public string? Ltaluka { get; set; }

    public string? Lcity { get; set; }

    public string? Lstate { get; set; }

    public string? LpinCode { get; set; }

    public string? Paddress { get; set; }

    public string? Ptaluka { get; set; }

    public string? Pcity { get; set; }

    public string? Pstate { get; set; }

    public string? PpinCode { get; set; }

    public string? Pphone { get; set; }

    public string? Caste { get; set; }

    public string? SubCaste { get; set; }

    public string? Category { get; set; }

    public string? Religion { get; set; }

    public string? Nationality { get; set; }

    public string? Mothertougue { get; set; }

    public string? Medium { get; set; }

    public string? AdmnYear { get; set; }

    public string? AcadYear { get; set; }

    public string? Class { get; set; }

    public string? Semester { get; set; }

    public string? NextYrClass { get; set; }

    public string? NextYrOddSem { get; set; }

    public string? Branch { get; set; }

    public string AdmnStatus { get; set; } = null!;

    public string? Admtype { get; set; }

    public string? AdmMode { get; set; }
}
