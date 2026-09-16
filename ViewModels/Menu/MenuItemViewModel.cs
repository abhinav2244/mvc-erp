namespace mvc_erp.ViewModels.Menu
{
    public class MenuItemViewModel
    {
        public int MenuSrNo { get; set; }

        public int? ParentId { get; set; }

        public string? Name { get; set; }

        public string? Url { get; set; }

        public string? MenuFlag { get; set; }

        public string? CssClass { get; set; }

        public int MenuSequence { get; set; }

        public List<MenuItemViewModel> Children { get; set; } = new();
    }
}
