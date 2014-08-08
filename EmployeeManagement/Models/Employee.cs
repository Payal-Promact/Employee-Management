using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public DateTime EmpDOJ { get; set; }
        public long EmpContactNo { get; set; }
        public decimal EmpSalary { get; set; }
        public int DeptID { get; set; }

        public virtual Department Department { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}