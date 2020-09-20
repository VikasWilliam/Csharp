using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ReactWebApi.Models;
using System.Data;
using System.Data.SqlClient;


namespace ReactWebApi.Controllers
{
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
        public List<Employee> GetAll()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee {Id=101,Name="John",Location="London",Salary=12345},
                new Employee {Id=102,Name="James",Location="New York",Salary=12345},
                new Employee {Id=103,Name="Philip",Location="Delhi",Salary=12345}
            };

            return emplist;
        }
        public bool Post(Employee employee)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-TTL9F68\SQLEXPRESS;database=ReactDb;integrated security = true");
            string query = "insert into EmployeeInfo values(@Id,@Name,@Location,@Salary)";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@Id", employee.Id));
            cmd.Parameters.Add(new SqlParameter("@Name", employee.Name));
            cmd.Parameters.Add(new SqlParameter("@Loc", employee.Location));
            cmd.Parameters.Add(new SqlParameter("@Sal", employee.Salary));
            
            int noOfRowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return noOfRowsAffected > 0 ? true : false;
        }

    }
}
