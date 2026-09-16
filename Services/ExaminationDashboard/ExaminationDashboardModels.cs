namespace mvc_erp.Services.ExaminationDashboard
{
    public class ExaminationDashboardModels
    {
        
        // DTO used to transfer schedule/event data from the Service
        // to the Examination Dashboard UI.
        //
        // We create a DTO here because the stored procedure
        // sp_GetEmployeeEventsAndHolidays returns a combination of
        // event data and display-related values. We don't need to
        // create another database table model just for this result.
        public class ScheduleEventDto
        {
            public int? EventId { get; set; }
            public string? EventName { get; set; }
            public string? EventDesc { get; set; }
            public DateTime? EventDate { get; set; }
            public DateTime? EventDateTo { get; set; }
            public TimeSpan? FromTime { get; set; }
            public TimeSpan? ToTime { get; set; }
            public string? Color { get; set; }

            public string? EventType { get; set; }
        }

        // Main ViewModel for the Examination Dashboard.
        //
        // The dashboard contains multiple independent sections such as
        // Exam Overview, My Schedules, Pending Exams, etc.
        // This ViewModel gives the Index View one object containing
        // all the data required by those sections.
        public class ExaminationDashboardViewModel
        {
            // Data used by the Exam Overview cards.
            public ExamOverview ExamOverview { get; set; } = new ExamOverview();

            // Data used by the My Schedules section.
            public List<ScheduleEventDto> ScheduleEvents { get; set; }
                = new List<ScheduleEventDto>();
        }

    }
}
