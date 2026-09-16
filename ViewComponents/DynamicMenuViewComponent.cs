using Microsoft.AspNetCore.Mvc;
using mvc_erp.Services;

namespace mvc_erp.ViewComponents
{
    public class DynamicMenuViewComponent : ViewComponent
    {
        private readonly MenuService _menuService;

        public DynamicMenuViewComponent(MenuService menuService)
        {
            _menuService = menuService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string? userLogId = HttpContext.Session.GetString("UserLogId");

            string? employeeId = HttpContext.Session.GetString("EmployeeID");

            string? catId = HttpContext.Session.GetString("CatId");

            if (string.IsNullOrWhiteSpace(userLogId) || string.IsNullOrWhiteSpace(catId))
            {
                return View(new List<ViewModels.Menu.MenuItemViewModel>());
            }

            var menus = await _menuService.GetUserMenuAsync(userLogId, employeeId, catId);

            return View(menus);
        }
    }
}
