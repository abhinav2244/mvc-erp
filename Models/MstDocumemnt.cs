using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstDocumemnt
{
    public int DocumemntsSrNo { get; set; }

    public string? DocumemntName { get; set; }

    public bool? IsDelete { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }

    public string? ExamType { get; set; }

    public virtual ICollection<HStudentDocumemntDetail> HStudentDocumemntDetails { get; set; } = new List<HStudentDocumemntDetail>();
}
