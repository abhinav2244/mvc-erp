using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TopicCovered
{
    public string? FacultyId { get; set; }

    public string? BranchName { get; set; }

    public string? Semester { get; set; }

    public string? Section { get; set; }

    public string? PeriodTime { get; set; }

    public int? LectureNo { get; set; }

    public string? LectureType { get; set; }

    public string? PracticalBatch { get; set; }

    public DateTime? PeriodDate { get; set; }

    public string? Topic { get; set; }

    public string? Unit { get; set; }

    public string? RoomNo { get; set; }

    public string? Lab { get; set; }

    public string? ClassLevel { get; set; }

    public string? AcadYear { get; set; }

    public int? Id { get; set; }

    public string? SubjectCode { get; set; }
}
