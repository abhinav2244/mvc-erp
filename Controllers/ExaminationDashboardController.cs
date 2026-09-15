using Microsoft.AspNetCore.Mvc;
using mvc_erp.Services.ExaminationDashboard;
using static mvc_erp.Services.ExaminationDashboard.ExaminationDashboardModels;

namespace mvc_erp.Controllers
{
    public class ExaminationDashboardController : Controller
    {
        private readonly ExaminationDashboardService _dashboardService;

        public ExaminationDashboardController(
            ExaminationDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        public async Task<IActionResult> Index()
        {
            var examOverview = await _dashboardService
                .GetExamOverviewAsync();

            // Get the currently logged-in employee's schedule events.
            // For now we are using the EmployeeID stored in Session,
            // just like the old Web Forms dashboard.

            int employeeId = HttpContext.Session.GetInt32("EmployeeId") ?? 0;
            var scheduleEvents = await _dashboardService.GetScheduleEventsAsync(employeeId);

            // Combine all dashboard sections into one ViewModel.
            var viewModel = new ExaminationDashboardViewModel
            {
                ExamOverview = examOverview,
                ScheduleEvents = scheduleEvents
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent(ScheduleEventDto model)
        {
            // This action receives the event details entered in the
            // Add Event modal and passes them to the service for saving.

            // EmployeeID belongs to the logged-in user's session,
            // so we read it in the Controller and pass it to the service.
            var employeeId = HttpContext.Session.GetInt32("EmployeeId") ?? 0;
            await _dashboardService.AddEventAsync(model, employeeId);

            return RedirectToAction(nameof(Index));
        }
    }
}