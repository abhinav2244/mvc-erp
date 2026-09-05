using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HStudentDocumemntDetail
{
    public int SrNo { get; set; }

    public int? StudSrNo { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? AcadmicYear { get; set; }

    public int? DocumemntId { get; set; }

    public bool? IsDelete { get; set; }

    public byte[]? StudPhotograph { get; set; }

    public byte[]? StudSignature { get; set; }

    public byte[]? StudCasteCertificate { get; set; }

    public byte[]? StudTc { get; set; }

    public byte[]? StudMarksheet { get; set; }

    public string? CollegeCode { get; set; }

    public virtual MstDocumemnt? Documemnt { get; set; }
}
