using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamForm
{
    public int ExamFormId { get; set; }

    public string? FormSerialNumber { get; set; }

    public int? ExamYearId { get; set; }

    public int? ExamId { get; set; }

    public string? ApplicantFristName { get; set; }

    public string? ApplicantMiddleName { get; set; }

    public string? ApplicantLastName { get; set; }

    public string? MobileNo { get; set; }

    public string? ApplicantAddress { get; set; }

    public string? CollegeCode { get; set; }

    public string? TownCode { get; set; }

    public int? CenterId { get; set; }

    public string? RegistrationNo { get; set; }

    public string? EnrollmentNo { get; set; }

    public string? FirstYearAdmitYear { get; set; }

    public int? CategoryOfExaminationId { get; set; }

    public int? MediumId { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public int? GenderId { get; set; }

    public string? CasteId { get; set; }

    public DateOnly? ApplicationDate { get; set; }

    public bool? IsDelete { get; set; }

    public string? RollNumber { get; set; }

    public int? CollegeId { get; set; }

    public int? Studid { get; set; }

    public string? WhatsAppNo { get; set; }

    public string? Email { get; set; }

    public string? CurrentYear { get; set; }

    public string? ClassLevelId { get; set; }

    public int? BranchId { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public bool? IsApproved { get; set; }

    public int? RoomNo { get; set; }

    public int? AssessmentId { get; set; }

    public int? BuildingId { get; set; }

    public int? IsSubmite { get; set; }

    public bool? Withheld { get; set; }

    public bool? WithheldSaved { get; set; }

    public string? WithheldRemark { get; set; }

    public bool? IsWithheld { get; set; }
}
