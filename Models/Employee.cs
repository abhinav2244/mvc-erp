using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string EmployeeCode { get; set; } = null!;

    public string StringCode { get; set; } = null!;

    public int NumericCode { get; set; }

    public string Gender { get; set; } = null!;

    public int CompanyId { get; set; }

    public int DepartmentId { get; set; }

    public string? Designation { get; set; }

    public int CategoryId { get; set; }

    public DateTime? Doj { get; set; }

    public DateTime? Dor { get; set; }

    public DateTime? Doc { get; set; }

    public string EmployeeCodeInDevice { get; set; } = null!;

    public string? EmployeeRfidnumber { get; set; }

    public string EmployementType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? EmployeeDevicePassword { get; set; }

    public string? EmployeeDeviceGroup { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? ResidentialAddress { get; set; }

    public string? PermanentAddress { get; set; }

    public string? ContactNo { get; set; }

    public string? Email { get; set; }

    public DateTime? Dob { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? Nomenee1 { get; set; }

    public string? Nomenee2 { get; set; }

    public string? Remarks { get; set; }

    public int? RecordStatus { get; set; }

    public string? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public string? C4 { get; set; }

    public string? C5 { get; set; }

    public string? C6 { get; set; }

    public string? C7 { get; set; }

    public string? Location { get; set; }

    public string? Bloodgroup { get; set; }

    public string? WorkPlace { get; set; }

    public string? ExtensionNo { get; set; }

    public string? LoginName { get; set; }

    public string? LoginPassword { get; set; }

    public string? Grade { get; set; }

    public string? Team { get; set; }

    public int? IsRecieveNotification { get; set; }

    public int? HolidayGroup { get; set; }

    public int? ShiftGroupId { get; set; }

    public int? ShiftRosterId { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? AadhaarNumber { get; set; }

    public byte[]? EmployeePhoto { get; set; }

    public int? MasterDeviceId { get; set; }

    public string? Biophoto1 { get; set; }

    public byte[]? BiophotoPic { get; set; }

    public int? DeviceExpiryRule { get; set; }

    public DateTime? DeviceExpiryStartDate { get; set; }

    public DateTime? DeviceExpiryEndDate { get; set; }

    public int? DeviceId { get; set; }

    public DateTime? EnrolledDate { get; set; }

    public int? MigrateToOtherCryptography { get; set; }

    public int? GeofenceId { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Nationality { get; set; }

    public string? PassportNumber { get; set; }

    public string? OverallExperience { get; set; }

    public string? Qualifications { get; set; }

    public string? ReferenceDetail { get; set; }

    public string? EmergencyContact { get; set; }

    public string? SubDepartment { get; set; }

    public string? Division { get; set; }
}
