using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeeManagement.Models;

namespace EmployeeManagement.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            var employees = new List<Employee>
            {
                new Employee{EmpID=1201,EmpName="Hillary Johnson",EmpDOJ=DateTime.Parse("2002-07-02"),EmpContactNo=9875864253,EmpSalary=30000,},
                new Employee{EmpID=1403,EmpName="Kiera Williams",EmpDOJ=DateTime.Parse("2004-08-03"),EmpContactNo=8745961653,EmpSalary=45000,},
            };
            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department{DeptID=101,DeptName="IT",},
                new Department{DeptID=103,DeptName="Computer",},
                new Department{DeptID=105,DeptName="Electrical",},
            };

            departments.ForEach(d => context.Departments.Add(d));
            context.SaveChanges();
            
        }
    
    }
}