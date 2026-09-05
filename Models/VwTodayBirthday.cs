using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class VwTodayBirthday
{
    public string PersonType { get; set; } = null!;

    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public string? PhoneNumber { get; set; }

    public string Smsstatus { get; set; } = null!;
}
