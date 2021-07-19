using AspMvcDemoProject.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspMvcDemoProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            
            return View(Repository.GetStudents());
        }

        public IActionResult GetStudentByCourseID(int? id)
        {
            var students = Repository.GetStudents()
                .Where(p => p.CourseID == id)
                .Select(e => e.StudentFName);
            return Content(string.Join("<br>", students));
        }
    }
}
