using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Qrptonlinestudsub
{
    public int SubjectCode { get; set; }

    public string? SubjectAbbr { get; set; }

    public string? SubjectName { get; set; }

    public string? SubjectPractical { get; set; }

    public byte? SubjectWorkload { get; set; }

    public string? AcadYear { get; set; }

    public int? BranchCode { get; set; }

    public string? ClassId { get; set; }

    public string? Semester { get; set; }

    public short? InternalMinMarks { get; set; }

    public short? InternalMaxMarks { get; set; }

    public short? OralMinMarks { get; set; }

    public short? OralMaxMarks { get; set; }

    public short? AssignMinMarks { get; set; }

    public short? AssignMaxMarks { get; set; }

    public short? PracticalMinMarks { get; set; }

    public short? PracticalMaxMarks { get; set; }

    public short? TheoryMinMarks { get; set; }

    public short? TheoryMaxMarks { get; set; }

    public string? SubCompulsary { get; set; }

    public DateTime? DateUpdated { get; set; }

    public short? NoOfPapers { get; set; }

    public string? ClassLevel { get; set; }

    public string? ThCode { get; set; }

    public string? Prcode { get; set; }

    public int SubSrNo { get; set; }

    public int? StudSrNo { get; set; }

    public string? Expr1 { get; set; }

    public string? Flag { get; set; }

    public string FlagDescription { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }

    public int Expr2 { get; set; }

    public int? StudId { get; set; }

    public string? StudFirstName { get; set; }

    public string? StudMiddleName { get; set; }

    public string? StudLastName { get; set; }

    public string? FatherFirstName { get; set; }

    public string? FatherMiddleName { get; set; }

    public string? FatherLastName { get; set; }

    public string? MotherFirstName { get; set; }

    public string? MotherMiddleName { get; set; }

    public string? MotherLastName { get; set; }

    public string? StudAddress { get; set; }

    public string? StudlTaluka { get; set; }

    public string? StudDistrict { get; set; }

    public string? StudPinCode { get; set; }

    public string? StudTelNo { get; set; }

    public string? StudMobNo { get; set; }

    public string? FatherMobNo { get; set; }

    public string? StudEmailId { get; set; }

    public DateTime? StudDob { get; set; }

    public string? StudNationality { get; set; }

    public string? StudMotherToungue { get; set; }

    public string? StudCategory { get; set; }

    public string? StudClassLevel { get; set; }

    public string? StudClass { get; set; }

    public string? StudBranch { get; set; }

    public string? StudSemister { get; set; }

    public string? OccupationofFather { get; set; }

    public string? AnnualIncome { get; set; }

    public string? LastAttendedCollege { get; set; }

    public string? PreviousClass { get; set; }

    public string? StudAggregateMarks { get; set; }

    public string? StudOutOf { get; set; }

    public string? StudScolarship { get; set; }

    public string? StudConcession { get; set; }

    public string? StudExtracurricularactivities { get; set; }

    public byte[]? StudPhotograph { get; set; }

    public byte[]? StudSignature { get; set; }

    public string? StudEnrolmentNo { get; set; }

    public string? AcademicYear { get; set; }

    public string? LastSubjectGroup { get; set; }

    public string? StikerNo { get; set; }

    public string? Remark { get; set; }

    public string? Expr3 { get; set; }

    public bool? Expr4 { get; set; }

    public bool? IsSubmit { get; set; }

    public string? StudGender { get; set; }

    public string? Caste { get; set; }

    public decimal? Percentage { get; set; }

    public string? BoardUniName { get; set; }

    public string? Medium { get; set; }

    public string? PreviousSection { get; set; }

    public string? AdharNo { get; set; }

    public string? SubjectGroup { get; set; }

    public int? Expr5 { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public bool? Step1 { get; set; }

    public DateTime? Step1DateTime { get; set; }

    public bool? Step2 { get; set; }

    public DateTime? Step2DateTime { get; set; }

    public bool? Step3 { get; set; }

    public DateTime? Step3DateTime { get; set; }

    public bool? Step4 { get; set; }

    public DateTime? Step4DateTime { get; set; }

    public DateTime? PrintApplicationForm { get; set; }

    public string? Extra1 { get; set; }

    public DateTime? Extra2 { get; set; }

    public int? Extra3 { get; set; }

    public bool? Extra4 { get; set; }

    public string? ElectionCardNo { get; set; }

    public int? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? PhysicalHandicap { get; set; }

    public string? Religion { get; set; }

    public string? State { get; set; }

    public string? Omslocal { get; set; }

    public int? PaymentModeId { get; set; }

    public string? ReceiptNo { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? Ddno { get; set; }

    public DateTime? Dddate { get; set; }

    public string? BankName { get; set; }

    public bool? IsPayment { get; set; }

    public string? HostelFacility { get; set; }

    public string? Qiindex { get; set; }

    public int? TotalObtianMarks { get; set; }

    public int? TotalOutOffMarks { get; set; }

    public int? TotalAttempts { get; set; }

    public string? Expr6 { get; set; }

    public string? Pcmmarks { get; set; }

    public string? Pcbmarks { get; set; }

    public string? BirthPlace { get; set; }
}
