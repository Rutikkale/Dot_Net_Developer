using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionMethodDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string show()
        {
            return " this is a second action method of home controller";
        }

        public ActionResult AboutUs()
        {
            return View();
        }
        public int studentID(int id)
        {
            return id;                                                              
        }
    }
}