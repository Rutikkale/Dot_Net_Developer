using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Message From View Bag !!";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();

            string[] fruits = { "Apple", " Orange" };
            ViewBag.FruitsArray = fruits;


            ViewBag.SportsList = new List<string>()
            {
                "Cricket",
                "Backetball",
                "Hockey",
                "BaseBall"
            };

            Employee Rutik = new Employee();

            Rutik.Empid = 1;
            Rutik.EmpName = "Rutik";
            Rutik.EmpDesignation = "Dot Net Developer";
            ViewBag.Employee = Rutik;


            ViewBag.CommonMessage = "This message is accessible by both ViewBag and ViewData!!";

            return View();
        }
    }
}