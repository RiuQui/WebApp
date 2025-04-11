using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class Students : Controller
    {
        public IActionResult Index()
        {
            StudentsPageViewModel resp = new StudentsPageViewModel();
            using (var db=new WebSysRGContext())
            {
                resp.Students = db.Students.ToList();
            }
            return View(resp);
        }
        public IActionResult Course()
        {
            CoursesPageViewModel resp = new CoursesPageViewModel(); 
            using (var db = new WebSysRGContext())
            {
                resp.Courses = db.Courses.ToList();
            }
            return View(resp);
        }
        public IActionResult Room()
        {

            return View();
        }
        public IActionResult Section()
        {
            return View();
        }
        public IActionResult Teacher()
        {
            return View();
        }

    }
}
