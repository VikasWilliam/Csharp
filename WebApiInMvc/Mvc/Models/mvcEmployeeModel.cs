using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Mvc.Models;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Models
{
    public class mvcEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage="This field is required")]
        public string Name { get; set; }
        public string Postion { get; set; }
        public string Age { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}