using CodeProjectMVCDemoLab1.Models;
using CodeProjectMVCDemoLab1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeProjectMVCDemoLab1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "Hello world is old its time for wassup bro!";
        }

        //public ActionResult GetView()
        //{
        //    //return View("MyView");
        //    Employee emp = new Employee();
        //    emp.FirstName = "Mahesh";
        //    emp.LastName = "Reddy";
        //    emp.Salary = 65000;
        //    //   ViewData["Employee"] = emp;
        //    //   return View("MyView");

        //    //ViewBag.Employee = emp;
        //    //return View("MyView");

        //    EmployeeViewModel vmEmployee = new EmployeeViewModel();
        //    vmEmployee.EmployeeName = emp.FirstName + " " + emp.LastName;
        //    vmEmployee.Salary = emp.Salary.ToString("C");
        //    if (emp.Salary > 15000)
        //    {
        //        vmEmployee.SalaryColor = "yellow";
        //    }
        //    else
        //    {
        //        vmEmployee.SalaryColor = "green";
        //    }
        //    //vmEmployee.UserName = "Admin";

        //    return View("MyView", vmEmployee);
        //}

        public ActionResult Index()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            //employeeListViewModel.UserName = "Admin";
            return View("Index", employeeListViewModel);
        }
        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }
        
        public ActionResult SaveEmployee(Employee e,string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                    
                    case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                        empBal.SaveEmployee(e);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("CreateEmployee");
                    }
                    
                    //return Content(e.FirstName + "|" + e.LastName + "|" + e.Salary);
                    
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult(); 
        }
    }
}