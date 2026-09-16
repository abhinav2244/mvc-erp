using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class QEmployeeMasterInfo
{
    public string InstitueteId { get; set; } = null!;

    public int EmployeeId { get; set; }

    public string Employee { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Taluka { get; set; } = null!;

    public string City { get; set; } = null!;

    public string PinCode { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string MaritalStatus { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string BirthDate { get; set; } = null!;

    public string Mothertoungue { get; set; } = null!;

    public string Caste { get; set; } = null!;

    public string SubCaste { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Religion { get; set; } = null!;

    public string Nationality { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public string JoiningDate { get; set; } = null!;

    public string RetirementDate { get; set; } = null!;

    public string EmpContract { get; set; } = null!;

    public string BloodGroup { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Panno { get; set; } = null!;

    public int PayScale { get; set; }

    public string GpfaccNo { get; set; } = null!;

    public string SalaryAccNo { get; set; } = null!;
}
