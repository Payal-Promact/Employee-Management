﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Models;
using EmployeeManagement.DAL;

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

       
	}
}