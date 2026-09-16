using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QStudDoc
{
    public string? StudName { get; set; }

    public DateTime? StudBirthDate { get; set; }

    public string? StudEnrollNo { get; set; }

    public string? StudClass { get; set; }

    public string? BranchName { get; set; }

    public string? ClassLevel { get; set; }

    public string? StudLastClass { get; set; }

    public string? UnivBoard { get; set; }

    public string? LastExamYear { get; set; }

    public string? StudAcadYear { get; set; }

    public int? Id { get; set; }

    public int? DocId { get; set; }

    public string? Remark { get; set; }

    public string? DocumentName { get; set; }
}
