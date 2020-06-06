using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ReactWebApi.Models;

namespace ReactWebApi.Controllers
{
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
        public List<Employee> GetAll()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee {Id=101,Name="Vikas",Location="Dhanbad",Salary=12345},
                new Employee {Id=102,Name="Vikas2",Location="Delhi",Salary=12345},
                new Employee {Id=103,Name="Vikas",Location="Pune",Salary=12345}




            };

            return emplist;
        }
    }
}
