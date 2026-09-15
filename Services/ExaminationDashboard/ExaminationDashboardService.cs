using Microsoft.EntityFrameworkCore;
using mvc_erp.Models;
using static mvc_erp.Services.ExaminationDashboard.ExaminationDashboardModels;

namespace mvc_erp.Services.ExaminationDashboard
{
    public class ExaminationDashboardService
    {
        private readonly ErpDbContext _context;

        public ExaminationDashboardService(ErpDbContext context)
        {
            _context = context;
        }

        // Gets the basic examination statistics for the dashboard
        public async Task<ExamOverview> GetExamOverviewAsync()
        {
            var today = DateTime.Today;

            var totalExams = await _context.MstExams
                .CountAsync();

            var activeExams = await _context.MstExams
                .CountAsync(x => x.IsActive == true);

            var regularExams = await _context.MstExams
                .CountAsync(x => x.AssessmentId == 1);

            var backlogExams = await _context.MstExams
                .CountAsync(x => x.AssessmentId == 3);

            var reExam = await _context.MstExams
                .CountAsync(x => x.AssessmentId == 2);

            return new ExamOverview
            {
                TotalExams = totalExams,
                ActiveExams = activeExams,
                RegularExams = regularExams,
                BacklogExams = backlogExams,
                ReExam = reExam
            };
        }

        // Gets the employee's schedule events and holidays for the
        // "My Schedules" section of the Examination Dashboard.
        //
        // The stored procedure already contains the required database
        // logic, so the Service only executes it and converts the result
        // into ScheduleEventDto objects that can be used by the MVC View.

        public async Task<List<ScheduleEventDto>> GetScheduleEventsAsync(int employeeId)
        {
            // Execute the existing stored procedure used by the old
            var events = await _context.Database
       .SqlQuery<ScheduleEventDto>(
           $"EXEC dbo.sp_GetEmployeeEventsAndHolidays @EmployeeID = {employeeId}")
       .ToListAsync();

            // Prepare default/display values here instead of putting
            // this logic inside the Controller or View.

            foreach (var item in events)
            {
                //if (string.IsNullOrWhiteSpace(item.EventTitle))
                //{
                //    item.EventTitle = "Untitled Event";
                //}

                if (string.IsNullOrWhiteSpace(item.EventDesc))
                {
                    item.EventDesc = "No description available";
                }

                if (string.IsNullOrWhiteSpace(item.Color))
                {
                    item.Color = "#48cb45";
                }

                if (string.IsNullOrWhiteSpace(item.EventType))
                {
                    item.EventType = "Event";
                }
            }

            return events;
        }

        public async Task AddEventAsync(ScheduleEventDto model,int employeeId)
        {
            // This method saves the event entered from the Add Event modal.
            // EmployeeID is passed from the Controller because the Controller
            // is responsible for accessing the current user's Session.

            await _context.Database.ExecuteSqlInterpolatedAsync($@"
        INSERT INTO mstScheduleEvents
        (
            AcadYear,
            EmployeeID,
            EventDate,
            EventName,
            FromTime,
            ToTime,
            IsEmp,
            IsDelete,
            EventDesc,
            Color,
            IsNotify,
            Email,
            NotifyTime,
            IsMailSent
        )
        VALUES
        (
            '2026-2027',
            {employeeId},
            {model.EventDate},
            {model.EventName},
            {model.FromTime},
            {model.ToTime},
            1,
            0,
            {model.EventDesc},
            {model.Color},
            0,
            NULL,
            NULL,
            0
        )");
        }
    }

    // Dashboard-specific result model.
    // This is NOT a database table model.
    public class ExamOverview
    {
        public int TotalExams { get; set; }

        public int ActiveExams { get; set; }

        public int RegularExams { get; set; }

        public int BacklogExams { get; set; }

        public int ReExam { get; set; }
    }
}
