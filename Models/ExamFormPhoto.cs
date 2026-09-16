using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class ExamFormPhoto
{
    public int ExamFormPhotoId { get; set; }

    public int? ExamFormId { get; set; }

    public byte[]? ApplicantPhoto { get; set; }

    public byte[]? ApplicantSignature { get; set; }

    public string? ExamPhotoPath { get; set; }

    public string? ExamSignaturePath { get; set; }

    public int? StudId { get; set; }
}
