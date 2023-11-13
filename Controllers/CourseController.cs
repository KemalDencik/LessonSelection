using Microsoft.AspNetCore.Mvc;
using LessonSelection.Models;


namespace LessonSelection.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        
        {
            return View();
        }

//get için
        public IActionResult Apply()
        {
            
            return View();
        }

        [HttpPost]
        //post için
        public IActionResult Apply(Student model)
        {
            
            return View();
        }
    }
}