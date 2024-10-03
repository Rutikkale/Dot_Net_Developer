using CrudAppUsingADO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudAppUsingADO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            employeeDBContext db = new employeeDBContext();
            List<employee> obj = db.GetEmployees();

            return View(obj);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(employee emp)
        {
            try
            {

                if (ModelState.IsValid == true)
                {
                    employeeDBContext context = new employeeDBContext();
                    bool check = context.AddEmployee(emp);
                    if (check == true)
                    {
                        TempData["InsertMessage"] = "Data has been Inserted Successfully !!!";
                        ModelState.Clear();
                        return RedirectToAction("Index");
                    }

                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit( int id)
        {
            employeeDBContext context = new employeeDBContext();
            var row = context.GetEmployees().Find(model => model.id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(int id,employee emp)
        {
            if (ModelState.IsValid == true)
            {
                employeeDBContext context = new employeeDBContext();
                bool check = context.UpdateEmployee(emp);
                if (check == true)
                {
                    TempData["UpdateMessage"] = "Data has been updated Successfully !!!";
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }

            }
            return View();
        }

        public ActionResult Details(int id)
        {
            employeeDBContext context = new employeeDBContext();
            var row = context.GetEmployees().Find(model => model.id == id);
            return View(row);
        }
        public ActionResult Delete(int id)
        {
            employeeDBContext context = new employeeDBContext();
            var row = context.GetEmployees().Find(model => model.id == id);
            return View(row);
        }

        [HttpPost]
        public ActionResult Delete(int id, employee emp)
        {
            employeeDBContext context = new employeeDBContext();
            bool check = context.DeleteEmployee(id);
            if (check == true)
            {
                TempData["DeleteMessage"] = "Data has been delete Successfully !!!";
                ModelState.Clear();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}