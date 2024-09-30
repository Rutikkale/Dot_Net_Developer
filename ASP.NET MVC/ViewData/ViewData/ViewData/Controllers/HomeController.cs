 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewData.Models;

namespace ViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message"] = "Message from View Data";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            string[] fruits = { "orange", "Apple", "Mango", "bluebarry","Banana"};
            ViewData["FruitsArrays"] = fruits;

            ViewData["Sportslist"] = new List<String>()
            {
                "Cricket",
                "Hockey",
                "Football",
                "football",

            };

            Employee rutik = new Employee();
            rutik.EmpID = 17;
            rutik.EmpName = "Rutik";
            rutik.EmpDesignation = "Manager";
            ViewData["Employee"] = rutik;

            return View();

        }
    }
}