using Drop_tut.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Drop_tut.Models;

namespace Drop_tut.Controllers
{
    public class HomeController : Controller
    {

        Drop_Context db = new Drop_Context();


        // GET: Home
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Student s1)
        {

            if (s1.StudentName == "student")
            {
                ModelState.AddModelError("StudentName", "Invalid name!!");
            }

            if (ModelState.IsValid)
            {
                db.Students.Add(s1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s1);
        }

        //private List<Student> myList { get; set; }
        Student s3 = new Student() { StudentName = "Paul", StudentGender = Gender.Male };
        List<Student> myList = new List<Student>();

        
        public ActionResult Database()
        {
            

            return View();
        }


        [HttpPost]
        public ActionResult Database(Student s4)
        {

            db.Students.Add(s4);
            db.SaveChanges();

            return RedirectToAction("Database");
        }


        public PartialViewResult Database2()
        {

            var result = db.Students.ToList();
            //myList.Add(s2);

            return PartialView("_Database2", result);
        }

        public PartialViewResult GetTime()
        {
            ViewBag.czas = DateTime.Now.ToLongTimeString();
            ViewBag.sample = "Jakis sampel";

            return PartialView("_GetTime");
        }


        public ActionResult Display2()
        {
            var result = db.Students
                .Where(c => c.StudentName == "adam").ToList();
            //myList.Add(s2);

            return View(result);
        }


    }
}