using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReactWebApi.Models;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http.Cors;


namespace ReactWebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class EmployeeAddController : ApiController
    {
        public bool Post(EmployeeAdd employee)
        {
            SqlConnection conn = new SqlConnection(@"server=DESKTOP-TTL9F68\SQLEXPRESS;database=BikeStore;integrated security=true");
            string query = "insert into EmployeeInfo values(@first_name,@last_name,@Locphone,@email,@street,@city,@state,@zip_code)";
            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.Parameters.Add(new SqlParameter("@Id", employee.Id));
            cmd.Parameters.Add(new SqlParameter("@first_name", employee.FirstName));
            cmd.Parameters.Add(new SqlParameter("@last_name", employee.LastName));
            cmd.Parameters.Add(new SqlParameter("@Locphone", employee.phone));
            cmd.Parameters.Add(new SqlParameter("@email", employee.email));
            cmd.Parameters.Add(new SqlParameter("@street", employee.street));
            cmd.Parameters.Add(new SqlParameter("@city", employee.city));
            cmd.Parameters.Add(new SqlParameter("@state", employee.state));
            cmd.Parameters.Add(new SqlParameter("@zip_code", employee.zipcode));
            conn.Open();
            int noOfRowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return noOfRowsAffected > 0 ? true : false;
        }
    }
}
