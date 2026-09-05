using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TeacherOtherProfile
{
    public int TeacherProfileId { get; set; }

    public int TeacherId { get; set; }

    public string? ProfessionalMemberships { get; set; }

    public string? ConsultancyActivities { get; set; }

    public string? GrantsResearchActivities { get; set; }

    public string? InteractionWithInstitutions { get; set; }

    public string? OtherAchievements { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? PatentsCount { get; set; }

    public int? CopyrightsCount { get; set; }

    public int? BooksCount { get; set; }

    public int? BookChaptersCount { get; set; }

    public int? IntJournalCount { get; set; }

    public int? IntConferenceCount { get; set; }

    public int? NatJournalCount { get; set; }

    public int? NatConferenceCount { get; set; }
}
