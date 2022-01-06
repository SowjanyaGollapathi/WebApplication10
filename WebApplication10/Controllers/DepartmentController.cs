using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            IList<Department> departments = new List<Department>();
            departments.Add(new Department() { DeptId = 1, DeptName = "Civil", DeptLocation = "Nellore" });
            departments.Add(new Department() { DeptId = 2, DeptName = "EEE", DeptLocation = "Nellore" });
            departments.Add(new Department() { DeptId = 3, DeptName = "MECH", DeptLocation = "Nellore" });
            departments.Add(new Department() { DeptId = 4, DeptName = "ECE", DeptLocation = "Nellore" });
            departments.Add(new Department() { DeptId = 5, DeptName = "CSE", DeptLocation = "Nellore" });

            ViewData["departments"] = departments;

            return View();
        }
    }
}
