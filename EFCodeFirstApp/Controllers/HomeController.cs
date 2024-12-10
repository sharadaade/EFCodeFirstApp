using EFCodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirstApp.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            //var data = db.Students.ToList();
            var data = db.Students.AsNoTracking().ToList();
            return View(data);
        }
    }
}