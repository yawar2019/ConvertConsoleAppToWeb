using System;
using System.Collections.Generic;

namespace TestCore.Models;

public partial class EmployeeModel
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public int EmpSalary { get; set; }

    public string? Designation { get; set; }

    public int DeptId { get; set; }
}
