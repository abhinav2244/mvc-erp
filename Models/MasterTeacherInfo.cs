using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MasterTeacherInfo
{
    public int TechId { get; set; }

    public string? TechUserCode { get; set; }

    public string? TechTitleCode { get; set; }

    public string? TechFname { get; set; }

    public string? TechMname { get; set; }

    public string? TechLname { get; set; }

    public string? TechAddress { get; set; }

    public string? TechCity { get; set; }

    public string? TechState { get; set; }

    public DateTime? TechBirthDate { get; set; }

    public string? TechEmailId { get; set; }

    public string? TechPhoneNo { get; set; }

    public string? TechQualificationCode { get; set; }

    public string? TechCollege { get; set; }

    public string? TechCollegePhoneNo { get; set; }

    public string? TechCollegeEmailId { get; set; }

    public string? TechUniversityCode { get; set; }

    public string? TechSubjectExpert { get; set; }

    public string? TechFacultyCode { get; set; }

    public string? TechStatus { get; set; }

    public string? TechTeachingExp { get; set; }

    public string? TechPaperPublish { get; set; }

    public string? TechAnswerForCode { get; set; }

    public byte[]? TechPhotograph { get; set; }

    public string? TechAddressFlag { get; set; }

    public string? TechBirthFlag { get; set; }

    public string? TechPhoneNoFlag { get; set; }

    public string? TechPpInternational { get; set; }

    public string? TechGender { get; set; }

    public string? TechRegistrationDate { get; set; }

    public string? TechNationalPpflag { get; set; }

    public string? TechInterNationalPpflag { get; set; }

    public string? TechActiveIn { get; set; }

    public string? TechBranch { get; set; }

    public string? TechIndustrialExp { get; set; }

    public string? TechTrainingAttend { get; set; }

    public DateTime? TechAppointDt { get; set; }

    public string? TechIndustTraining { get; set; }

    public string? TechExtInCharge { get; set; }

    public int? TechPpNational { get; set; }

    public int? TechPpState { get; set; }

    public string? AssignmentAs { get; set; }

    public string? AcademicYear { get; set; }

    public string? Remarks { get; set; }

    public string? UploadedDocument { get; set; }

    public virtual ICollection<TeacherQualification> TeacherQualifications { get; set; } = new List<TeacherQualification>();
}
