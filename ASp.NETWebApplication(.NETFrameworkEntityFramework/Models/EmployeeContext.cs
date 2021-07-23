using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASp.NETWebApplication_.NETFrameworkEntityFramework.Models
{
    public class EmployeeContext :Dbcontext
    {
        public EmployeeContext() : base("Connection") { }
        public DbSet<Employee> Employees { get; set; }

    }
}