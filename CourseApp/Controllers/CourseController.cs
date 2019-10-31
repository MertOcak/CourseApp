using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{

    // localhost:5000/course
    public class CourseController : Controller
    {

        //action method
        //localhost:5000/course/index => course/index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult Apply(string Name, string Email, string Phone, bool Confirm)
        public IActionResult Apply(Student student)
        {
            // Model Binding
            // database kayıt
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View(student);
            }

        }




        //localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            var students = Repository.Students.Where(i => i.Confirm == true);
            return View(students);
        }

        public IActionResult Details()
        {
            // View ismi verilirse, ismi verilen view'i klasör altından arar ve ona yönlenir

            // name: "Core Mvc Kursu"
            // description: "güzel bir kurs"
            // isPublished: true

            // return View("MyView");

            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.Description = "güzel bir kurs";
            course.IsPublished = true;
            // İstediğimiz başka bir viewe de bu model type'ında data gönderebiliriz
            // return View("MyView",course);
            return View(course);
        }
    }
}
