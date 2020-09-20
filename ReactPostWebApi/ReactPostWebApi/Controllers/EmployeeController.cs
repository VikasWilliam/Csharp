using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReactPostWebApi.Models;
using System.Web.Http.Cors;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ReactPostWebApi.Controllers
{
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
        public List<Employee> GetAll()
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee { Id=101,Name="Abhinav",Location="Banglore",Salary=12345},
                new Employee { Id=102,Name="Vikas",Location="Banglore",Salary=123478},

            };
            return empList;
        }

        public bool Post(Employee employee)
        {
            SqlConnection conn = new SqlConnection(@"server=DESKTOP-TTL9F68\SQLEXPRESS;database=ReactAppDB;integrated security=SSPI");
            string query = "insert into EmpoloyeeInfo values(@Id,@Name,@Loc,@Sal)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@Id", employee.Id));
            cmd.Parameters.Add(new SqlParameter("@Name", employee.Name));
            cmd.Parameters.Add(new SqlParameter("@Loc", employee.Location));
            cmd.Parameters.Add(new SqlParameter("@Sal", employee.Salary));
            conn.Open();
            int noOfRowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return noOfRowsAffected > 0 ? true : false;
        }
    }
}
