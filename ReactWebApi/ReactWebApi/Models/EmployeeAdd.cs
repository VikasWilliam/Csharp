using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactWebApi.Models
{
    public class EmployeeAdd
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
    }
}