using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Applicationreceived
{
    public int? ApplicationNo { get; set; }

    public DateTime? AppReceivedDate { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateOfbirth { get; set; }

    public string? BirthPlace { get; set; }

    public string? Sex { get; set; }

    public string? Nationality { get; set; }

    public string? Religion { get; set; }

    public string? Community { get; set; }

    public string? MotherTounge { get; set; }

    public string? Class { get; set; }

    public string? Branch { get; set; }

    public string? LastClass { get; set; }

    public string? LastSchool { get; set; }

    public string? LastResult { get; set; }

    public double? MarksObtain { get; set; }

    public double? MarksOutOf { get; set; }

    public double? Percentage { get; set; }

    public string? PresentStreetAdd { get; set; }

    public string? PresentCity { get; set; }

    public string? PresentState { get; set; }

    public double? PresentPinCode { get; set; }

    public int? PresentPhonNo { get; set; }

    public string? PermanantStreetAdd { get; set; }

    public string? PermanantCity { get; set; }

    public string? PermanantState { get; set; }

    public int? PermanantPinCode { get; set; }

    public int? PermanantPhonNo { get; set; }

    public string? Email { get; set; }

    public string? ClassLevel { get; set; }
}
