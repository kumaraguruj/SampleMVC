
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3.ViewModel;

namespace WebApplication3.Models
{
    public class EmployeeBusinessLayer
    {
        public DbSet<EmployeeMaster> Employees { get; set; }
    }
}