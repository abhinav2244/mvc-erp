using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class StudentAttendanceTopic
{
    public int TopicDetailId { get; set; }

    public int Samid { get; set; }

    public int TopicId { get; set; }

    public virtual StudentAttendanceMaster Sam { get; set; } = null!;
}
