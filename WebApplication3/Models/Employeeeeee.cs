using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class Employeeeeee: DbContext
    {
        public DbSet<EmployeeMaster> Employeeees { get; set; }
    }
}