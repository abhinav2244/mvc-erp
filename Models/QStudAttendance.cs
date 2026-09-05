using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QStudAttendance
{
    public int StudId { get; set; }

    public string? StudFirstName { get; set; }

    public string? StudMiddleName { get; set; }

    public string? StudLastName { get; set; }

    public string? StudLocalAddress { get; set; }

    public string? StudLocalTaluka { get; set; }

    public string? StudLocalCity { get; set; }

    public string? StudLocalPinCode { get; set; }

    public string? StudLocalState { get; set; }

    public string? StudLocalPhone { get; set; }

    public string? StudPermanantAddress { get; set; }

    public string? StudPermanantTaluka { get; set; }

    public string? StudPermanantCity { get; set; }

    public string? StudPermanantPinCode { get; set; }

    public string? StudPermanantState { get; set; }

    public string? StudPermanantPhone { get; set; }

    public string? StudFathersName { get; set; }

    public string? StudClass { get; set; }

    public string? StudSection { get; set; }

    public string? ClassLevel { get; set; }

    public int? BranchCode { get; set; }

    public string? StudSemester { get; set; }

    public string? StudAcadYear { get; set; }

    public string? SubjectName { get; set; }

    public double? AttPercent { get; set; }

    public string? UserLogin { get; set; }

    public string? StudPhoto { get; set; }

    public string? Subject { get; set; }
}
