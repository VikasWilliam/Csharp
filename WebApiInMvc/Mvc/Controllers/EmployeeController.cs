using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc.Models;
using System.Net.Http;

namespace Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<mvcEmployeeModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employee").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result;
            return View(empList);
        }
        public ActionResult AddorEdit(int id=0)
        {
            if(id==0)
            {
                return View(new mvcEmployeeModel());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employee/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcEmployeeModel>().Result);
            }

            
        }
        [HttpPost]
        public ActionResult AddorEdit(mvcEmployeeModel emp)
        {
            if (emp.EmployeeId == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Employee", emp).Result;
                TempData["SuccessMessage"] = "Entry Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Employee/"+emp.EmployeeId, emp).Result;
                TempData["SuccessMessage"] = "Updated Successfully";

            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Employee/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}