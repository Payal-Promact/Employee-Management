using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EmployeeManagement.Models;
using EmployeeManagement.DAL;

namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private EmployeeDBContext db = new EmployeeDBContext();
        
        //
        // GET: /Department/
        public ViewResult Index()
        {
            return View(db.Departments.ToList());
        }
	}
}