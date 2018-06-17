using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    }

    
    public class TestController : Controller
    {        
        private Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address1";
            return c;
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            //emp.FirstName = "Prashanth";
            //emp.LastName = "Jagannath";
            //emp.Salary = 100;

            ViewData["EmpData"] = emp;

            return View("GetView");
        }

        public ViewResult GetView1()
        {
            EmployeeListViewModel empListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBusinessLayer = new EmployeeBusinessLayer();

            //List<Employee> employees = empBusinessLayer.GetEmployees();

            //List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            //foreach (Employee emp in employees)
            //{
            //    EmployeeViewModel empViewModel = new EmployeeViewModel();
            //    empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
            //    empViewModel.Salary = emp.Salary.ToString("C");
            //    if (emp.Salary > 15000)
            //    {
            //        empViewModel.SalaryColor = "yellow";
            //    }
            //    else
            //    {
            //        empViewModel.SalaryColor = "green";
            //    }
            //    empViewModels.Add(empViewModel);
            //}
            //empListViewModel.Employees = empViewModels;
            //empListViewModel.UserName = "Admin";


            //Employee emp = new Employee();
            //emp.FirstName = "Prashanth";
            //emp.LastName = "Jagannath";
            //emp.Salary = 100;
            //EmployeeViewModel vemp = new EmployeeViewModel();

            //vemp.UserName = "Admin";
            //vemp.EmployeeName = emp.FirstName + " " + emp.LastName;
            //vemp.Salary = emp.Salary.ToString("C");
            //if (emp.Salary>50)
            //{
            //    vemp.SalaryColor = "yellow";
            //}
            //else
            //{
            //    vemp.SalaryColor = "green";
            //}

            return View("MyView", empListViewModel);
        }        

    }
}