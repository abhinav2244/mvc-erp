using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class MstUserWiseMenu
{
    public int UserMenuId { get; set; }

    public int EmployeeId { get; set; }

    public int CatId { get; set; }

    public int MenuId { get; set; }

    public bool IsAdded { get; set; }
}
