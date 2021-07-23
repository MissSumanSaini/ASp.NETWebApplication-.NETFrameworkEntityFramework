using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASp.NETWebApplication_.NETFrameworkEntityFramework.Models
{
    public class Employee
    {
        [key]
        public int id { get; set; }
        public string Name { get; set; }
        public int MobileNo { get; set; }
        public string Image { get; set; }
        public decimal Salary { get; set; }
        public string  Email { get; set; }

    }
}