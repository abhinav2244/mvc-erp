using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class BioAttEmployee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string EmployeeCode { get; set; } = null!;

    public string StringCode { get; set; } = null!;

    public int NumericCode { get; set; }

    public string Gender { get; set; } = null!;

    public int CompanyId { get; set; }

    public int DepartmentId { get; set; }

    public string Designation { get; set; } = null!;

    public int CategoryId { get; set; }

    public DateTime Doj { get; set; }

    public DateTime Dor { get; set; }

    public DateTime Doc { get; set; }

    public string EmployeeCodeInDevice { get; set; } = null!;

    public int EmployeeRfidnumber { get; set; }

    public string EmployementType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string EmployeeDevicePassword { get; set; } = null!;

    public string EmployeeDeviceGroup { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public string MotherName { get; set; } = null!;

    public string ResidentialAddress { get; set; } = null!;

    public string PermenentAddress { get; set; } = null!;

    public string ContactNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string PlaceOfBirth { get; set; } = null!;

    public string Nomenee1 { get; set; } = null!;

    public string Nomenee2 { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public string RecordStatus { get; set; } = null!;

    public string? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public string? C4 { get; set; }

    public string? C5 { get; set; }

    public string C6 { get; set; } = null!;

    public string C7 { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string BloodGroup { get; set; } = null!;

    public string WorkPlace { get; set; } = null!;

    public string ExtensionNo { get; set; } = null!;

    public string LoginPassword { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public string Team { get; set; } = null!;

    public string IsReceiveNotification { get; set; } = null!;

    public int HolidayGroup { get; set; }

    public int ShiftGroupId { get; set; }

    public int ShiftRosterId { get; set; }
}
