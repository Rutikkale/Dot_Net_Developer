using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Validation_Message_Summary.Controllers
{
    public class HomeController : Controller
    {
        string emailpatter = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string FullName, String Age, String Email)
        {
            if (FullName.Equals("") == true)
            {
                ModelState.AddModelError("FullName", "Enter Fullname!!");
                ViewData["FullNameError"] = "*";
            }
            if (Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", "Age is Required!!");
                ViewData["AgeError"] = "*";
            }
            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is Required!!");
                ViewData["EmailError"] = "*";
            }
            else
            {
                if (Regex.IsMatch(Email,emailpatter)==false)
                {

                    ModelState.AddModelError("Email", "Invalid Email!!");
                    ViewData["EmailError"] = "*";
                }
            }
            if (ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<Script>alert('Data has been Submitted!!')</Script>";
                ModelState.Clear();
            }

            return View();
        }
    }
}