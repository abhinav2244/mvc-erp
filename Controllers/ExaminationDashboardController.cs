using Microsoft.AspNetCore.Mvc;

namespace mvc_erp.Controllers
{
    public class ExaminationDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
