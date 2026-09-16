using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstAlumniRegistration
{
    public int AlumniId { get; set; }

    public int? StudId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? MaritialStatus { get; set; }

    public string? TelephoneNo { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? ResAddress { get; set; }

    public string? City { get; set; }

    public string? Pincode { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Course { get; set; }

    public string? PassingYear { get; set; }

    public string? Profession { get; set; }

    public string? Organisation { get; set; }

    public string? Position { get; set; }

    public string? AboutCollege { get; set; }

    public string? MemorableMoment { get; set; }
}
