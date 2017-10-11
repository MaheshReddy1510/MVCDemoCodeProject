using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeProjectMVCDemoLab1.DataAccessLayer;

namespace CodeProjectMVCDemoLab1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            var emp1 = new Employee
            {
                FirstName = "Rohit",
                LastName = "Sharma",
                Salary = 25000,
            };
            employees.Add(emp1);

            var emp2 = new Employee
            {
                FirstName = "Virat",
                LastName = "Kohli",
                Salary = 5000
            };
            employees.Add(emp2);

            var emp3 = new Employee
            {
                FirstName = "Suresh",
                LastName = "Raina",
                Salary = 50000
            };
            employees.Add(emp3);

            Employee emp4 = new Employee();
            emp4 = new Employee();
            emp4.FirstName = "Hardik";
            emp4.LastName = "Pandya";
            emp4.Salary = 9000;
            employees.Add(emp4);

            return employees;
        }

        //public List<Employee> GetEmployees()
        //{
        //    SalesERPDAL salesDal = new SalesERPDAL();
        //    return salesDal.Employees.ToList();
        //}
        public Employee SaveEmployee(Employee e)
        {
            //SalesERPDAL salesDal = new SalesERPDAL();
            //salesDal.Employees.Add(e);
            //salesDal.SaveChanges();
            //return e;
                var emp = new Employee
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Salary = e.Salary
                };
                return e;
        }
    }
}