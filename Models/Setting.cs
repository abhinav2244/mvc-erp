using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Setting
{
    public byte Id { get; set; }

    public string? AdminId { get; set; }

    public string? AdminPass { get; set; }

    public short AbbreviateDays { get; set; }

    public short AbbreviateMonths { get; set; }

    public short EventDisplay { get; set; }

    public short AmericanTime { get; set; }

    public string? PageTitle { get; set; }

    public string? BackgroundColor { get; set; }

    public string? FontColor { get; set; }

    public string? LinkColor { get; set; }

    public string? HoverLinkColor { get; set; }

    public string? VisitedLinkColor { get; set; }

    public string? ActiveLinkColor { get; set; }

    public string? WeekdayFont { get; set; }

    public string? WeekdayFontSize { get; set; }

    public string? WeekdayFontColor { get; set; }

    public string? WeekdayBackgroundColor { get; set; }

    public string? DateFont { get; set; }

    public string? DateFontSize { get; set; }

    public string? DateFontColor { get; set; }

    public string? DateBackgroundColor { get; set; }

    public string? EventFont { get; set; }

    public string? EventFontSize { get; set; }

    public string? EventFontColor { get; set; }

    public string? CellBackgroundColor { get; set; }

    public string? CellWidth { get; set; }

    public string? CellHeight { get; set; }

    public string? BorderSize { get; set; }

    public string? BorderColor { get; set; }

    public string? Header { get; set; }

    public string? Footer { get; set; }
}
