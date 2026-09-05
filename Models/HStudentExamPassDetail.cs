using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class HStudentExamPassDetail
{
    public int SrNo { get; set; }

    public int? StudSrNo { get; set; }

    public string? ExaminationName { get; set; }

    public string? RollNo { get; set; }

    public string? EnrolmentNo { get; set; }

    public string? BoardUniversity { get; set; }

    public string? PassingYear { get; set; }

    public string? TotalMarks { get; set; }

    public string? PercentageOfMarks { get; set; }

    public string? Flag { get; set; }

    public bool? IsDelete { get; set; }

    public string? ObtainMarks { get; set; }

    public string? Division { get; set; }

    public int? MarksInMajorSubject { get; set; }

    public int? MarksInAdminIsSought { get; set; }

    public int? NoOfAttepts { get; set; }

    public string? Session { get; set; }

    public string? AdmissionYear { get; set; }

    public string? CoursePattern { get; set; }

    public string? Semester { get; set; }

    public int? Attempt { get; set; }

    public int? CollegeSrNo { get; set; }

    public string? CollegeCode { get; set; }
}
