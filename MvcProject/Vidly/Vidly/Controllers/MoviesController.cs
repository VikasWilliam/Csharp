using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Random()
        {
            var movie = new Movie() { Name="ShreK!!",ID=101};
             return View(movie);

           // return new EmptyResult();
        }
    }
}