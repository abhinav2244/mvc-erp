using Microsoft.Data.SqlClient;
using mvc_erp.Models;
using mvc_erp.ViewModels.Menu;

namespace mvc_erp.Services
{
    public class MenuService
    {
        private readonly IConfiguration _configuration;

        public MenuService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<MenuItemViewModel>> GetUserMenuAsync(string userLogId, int? employeeId, string catId)
        {
            var allowedMenuIds = await GetAllowedMenuIdsAsync(userLogId, employeeId, catId);

            if (allowedMenuIds.Count == 0)
                return new List<MenuItemViewModel>();

            var menus = await GetMasterMenuAsync(allowedMenuIds);

            return BuildMenuTree(menus);
        }
        private async Task<List<int>> GetAllowedMenuIdsAsync(string userLogId, int? employeeId, string catId)
        {
            var result = new List<int>();

            await using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            await connection.OpenAsync();

            const string sql = @"SELECT DISTINCT Menu_SrNo
                FROM
                (
                    SELECT Menu_SrNo
                    FROM mstCategoryWiseMenu
                    WHERE CatId = @CatId

                    UNION

                    SELECT MenuID AS Menu_SrNo
                    FROM mstUserWiseMenu
                    WHERE IsAdded = 1
                      AND EmployeeID = @EmployeeID
                      AND CatID = @CatId

                    EXCEPT

                    SELECT MenuID AS Menu_SrNo
                    FROM mstUserWiseMenu
                    WHERE IsAdded = 0
                      AND EmployeeID = @EmployeeID
                      AND CatID = @CatId
                ) A;";

            await using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@CatId", catId);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);

            await using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                result.Add(Convert.ToInt32(reader["Menu_SrNo"]));
            }
            return result;
        }
        private List<MenuItemViewModel> BuildMenuTree(List<MenuItemViewModel> menus)
        {
            var mainMenus = menus.Where(x => x.MenuFlag == "M" && x.Url == "-").OrderBy(x => x.MenuSequence).ToList();

            foreach (var main in mainMenus)
            {
                main.Children = menus.Where(x => x.MenuFlag == "S" && x.ParentId == main.MenuSrNo).OrderBy(x => x.MenuSequence).ToList();
                foreach (var sub in main.Children)
                {
                    sub.Children = menus.Where(x => x.MenuFlag == "SS" && x.ParentId == sub.MenuSrNo).OrderBy(x => x.MenuSequence).ToList();
                }
            }
            return mainMenus;
        }
        private async Task<List<MenuItemViewModel>> GetMasterMenuAsync(List<int> menuIds)
        {
            var menus = new List<MenuItemViewModel>();

            if (menuIds == null || menuIds.Count == 0)
                return menus;

            string connectionString = _configuration.GetConnectionString("MasterDbConnection");

            await using var connection = new SqlConnection(connectionString);

            await connection.OpenAsync();

            var parameterNames = menuIds.Select((id, index) => $"@MenuId{index}").ToList();

            string sql = $@" SELECT
                            Menu_SrNo,
                            Menu_Main_ID,
                            Menu_Main_Sub_Name,
                            Menu_Form_Link,
                            Menu_Flag,
                            cssClass,
                            MenuSequence
                        FROM Master_Menu
                        WHERE Menu_SrNo IN ({string.Join(",", parameterNames)})
                        ORDER BY Menu_Flag, MenuSequence;";

            await using var command = new SqlCommand(sql, connection);

            for (int i = 0; i < menuIds.Count; i++)
            {
                command.Parameters.AddWithValue($"@MenuId{i}", menuIds[i]);
            }

            await using  var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var menu = new MenuItemViewModel()
                {
                    MenuSrNo = reader["Menu_SrNo"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Menu_SrNo"]),
                    ParentId = reader["Menu_Main_ID"] == DBNull.Value ? null : Convert.ToInt32(reader["Menu_Main_ID"]),
                    Name = reader["Menu_Main_Sub_Name"] == DBNull.Value ? "" : reader["Menu_Main_Sub_Name"].ToString()?.Trim(),
                    Url = reader["Menu_Form_Link"] == DBNull.Value ? "" : reader["Menu_Form_Link"].ToString()?.Trim(),
                    MenuFlag = reader["Menu_Flag"] == DBNull.Value ? "" : reader["Menu_Flag"].ToString()?.Trim(),
                    CssClass = reader["cssClass"] == DBNull.Value ? "" : reader["cssClass"].ToString()?.Trim(),
                    MenuSequence = reader["MenuSequence"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MenuSequence"])
                };
                menus.Add(menu);
            }
            return menus;
        }
    }
}
