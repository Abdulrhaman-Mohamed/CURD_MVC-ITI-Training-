using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Semi_project.Models;
using System.Data.Entity;

namespace Semi_project.Controllers
{
    public class proController : Controller
    {
        Model1 Models = new Model1();
        // GET: pro

        [HttpGet]
        public ActionResult Thepage()
        {

            var e1 = Models.Employees.Include(ee => ee.Department).ToList();
            return View(e1);
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult create(Employee e1)
        {
            Models.Employees.Add(e1);
            Models.SaveChanges();
            return RedirectToAction("Thepage");

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var e1 = Models.Employees.Find(id);
            return View(e1);

        }


        [HttpPost]
        public ActionResult Edit(int id ,Employee employee)
        {
            var e2= Models.Employees.Find(id);
           
            e2.name_ = employee.name_;
            e2.age = employee.age;
            e2.salary = employee.salary;
            e2.Dept_ID=employee.Dept_ID;
            //Models.Entry(employee).State = EntityState.Modified;

            Models.SaveChanges();
            return RedirectToAction("Thepage");

        }

        public ActionResult Info(int id)
        {
            var e1 = Models.Employees.Find(id);
            return View(e1);
        }

        public ActionResult Delete(int id)
        {
            var e1 = Models.Employees.Find(id);
            Models.Employees.Remove(e1);
            Models.SaveChanges();
            return RedirectToAction("ThePage");

        }

    }
}