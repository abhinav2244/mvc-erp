using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class SyllabusDetail
{
    public int SubTopicId { get; set; }

    public int? SubSylId { get; set; }

    public string? SubDescription { get; set; }

    public virtual Syllabus? SubSyl { get; set; }
}
