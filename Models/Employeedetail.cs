using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class Employeedetail
{
    public string? EmployeeCode { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpMiddleName { get; set; }

    public string? EmpLastName { get; set; }

    public string? Payscale { get; set; }

    public string? DepartmentId { get; set; }

    public DateTime? DeptWefdate { get; set; }

    public string? DesignationId { get; set; }

    public DateTime? DesigWefdate { get; set; }

    public string? GradeId { get; set; }

    public DateTime? GradeWefdate { get; set; }

    public string? QualificationId { get; set; }

    public string? OtherQualification { get; set; }

    public DateTime? QualiWefdate { get; set; }

    public string? MaritalStatusId { get; set; }

    public DateTime? MaritalStatusWefdate { get; set; }
}
