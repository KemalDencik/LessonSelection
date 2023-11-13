using Microsoft.AspNetCore.Mvc;
using LessonSelection.Models;


namespace LessonSelection.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }

//get için
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //güvenlik için 
        //post için
        public IActionResult Apply([FromForm]Student model)
        {
            if(Repository.Applications.Any(c => c.Email!.Equals(model.Email))) //bir kişi tek bir başvuru yapabilir
            {
                ModelState.AddModelError("","There is Already an application for you"); 
            }
            if(ModelState.IsValid) //boş alan eklemesini önleme işlemi
            {
            Repository.Add(model);
            return View("Feedback",model);
            }
            return View();
           
        }
    }
}