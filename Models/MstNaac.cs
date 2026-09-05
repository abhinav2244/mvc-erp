using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstNaac
{
    public int Naacid { get; set; }

    public string? CollegeName { get; set; }

    public string? CollegeAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PinCode { get; set; }

    public string? Website { get; set; }

    public string? DesignationId { get; set; }

    public string? InstitustionStatus { get; set; }

    public string? ByGender { get; set; }

    public string? ByShift { get; set; }

    public string? RecognizedMinorityInst { get; set; }

    public DateOnly? EstablishmentDate { get; set; }

    public string? UniversityState { get; set; }

    public string? UniversityName { get; set; }

    public string? DocumentPath { get; set; }

    public bool? DeatailsOfAntonomy { get; set; }

    public bool? RecognizedByUgc { get; set; }

    public DateOnly? RecognitionDate { get; set; }

    public bool? OtherGovagency { get; set; }

    public string? CampusType { get; set; }

    public string? CampusAddress { get; set; }

    public string? CampusLocation { get; set; }

    public string? CampAreaInAcres { get; set; }

    public string? BuiltareaInSqmst { get; set; }

    public int? VisitingMaleCount { get; set; }

    public int? VisitingFemaleCount { get; set; }

    public int? VisitingOthersCount { get; set; }

    public int? VisitingTotalCount { get; set; }
}
