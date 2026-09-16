using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentDetail
{
    public int StudId { get; set; }

    public string StudCode { get; set; } = null!;

    public string? StudTitle { get; set; }

    public string? StudFname { get; set; }

    public string? StudMname { get; set; }

    public string? StudLname { get; set; }

    public DateTime? StudBdate { get; set; }

    public string? StudBdflag { get; set; }

    public string? StudGender { get; set; }

    public string? StudAddress { get; set; }

    public string? StudAddrFlag { get; set; }

    public string? StudCity { get; set; }

    public string? StudState { get; set; }

    public string? StudEmailId { get; set; }

    public string? StudPhoneNo { get; set; }

    public string? StudPhflag { get; set; }

    public string? StudStream { get; set; }

    public string? StudQualification { get; set; }

    public string? StudUniversity { get; set; }

    public string? StudCollege { get; set; }

    public string? StudStatus { get; set; }

    public string? StudAnswerFor { get; set; }

    public byte[]? StudPhotograph { get; set; }
}
