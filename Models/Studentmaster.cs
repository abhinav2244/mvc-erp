using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Studentmaster
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

    public string? StudFathersOccupationId { get; set; }

    public string? StudFathersQualificationId { get; set; }

    public double? StudFathersIncome { get; set; }

    public string? StudMothersName { get; set; }

    public string? StudMothersOccupationId { get; set; }

    public string? StudMothersQualificationId { get; set; }

    public double? StudMothersIncome { get; set; }

    public string? StudGuardiansName { get; set; }

    public string? StudGuardiansAddress { get; set; }

    public string? StudGuardiansPhone { get; set; }

    public string? StudSex { get; set; }

    public DateTime? StudBirthDate { get; set; }

    public string? StudBirthPlace { get; set; }

    public string? StudCaste { get; set; }

    public string? StudSubCaste { get; set; }

    public string? StudCommunityId { get; set; }

    public string? StudReligionId { get; set; }

    public string? StudNationalityId { get; set; }

    public string? StudMothertongueId { get; set; }

    public string? StudHeight { get; set; }

    public string? StudWeight { get; set; }

    public string? StudIdMark1 { get; set; }

    public string? StudIdMark2 { get; set; }

    public string? StudDeformity { get; set; }

    public string? StudUserName { get; set; }

    public string? StudPhoto { get; set; }

    public string? StudRemarks { get; set; }

    public string? StudDobInWords { get; set; }

    public string? BaseAcadYear { get; set; }

    public string? UserStudId { get; set; }

    public string? FatherEmailId { get; set; }

    public string? MotherEmailId { get; set; }

    public string? GuardianEmailId { get; set; }

    public string? FatherMobile { get; set; }

    public string? MotherMobile { get; set; }

    public string? GuardianMobile { get; set; }

    public string? GuardianOccupation { get; set; }

    public string? CasteCertiNo { get; set; }

    public string? CasteValiCertiNo { get; set; }

    public int? CapMeritNo { get; set; }

    public string? AdharNo { get; set; }

    public string? ElectionCardNo { get; set; }

    public string? StudPanno { get; set; }

    public string? PancardNo { get; set; }

    public string? DglockerNo { get; set; }
}
