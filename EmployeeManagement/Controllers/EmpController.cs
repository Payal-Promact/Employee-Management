using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class EmpController : Controller
    {
        private EmployeeDBContext db = new EmployeeDBContext();
        //
        // GET: /Emp/
        public ViewResult Index()
        {
            return View(db.Employees.ToList());
        }

        //GET: /Employee/Welcome
      /*  public string Welcome()
        {
            return "This is the Welcome method";
        }*/

        //GET: /Employee/Welcome
        public ActionResult Welcome(string EmpName,int ID)
        {
            ViewBag.Message = "Hello" + EmpName;
            ViewBag.ID = "ID =" + ID;

            return View();
        }
	}
}