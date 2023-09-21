using ControllersSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllersSample.Controllers
{
    [Route("Ucenici")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // return View("StudentIndex");
            // return View("List");

           // return RedirectToAction("List");
           return RedirectToAction("Privacy", "Home");
        }

        [HttpGet("Lista")]
        public IActionResult List() 
        {
            // This is complex logic which pulls the data from database
            // this has 1000 lines of code

            ViewResult view = View();

            return view;
        }

        // [HttpGet("Detalji/{studentId}")] this will be used in the way Ucenici/Detalji/1
        [HttpGet("Detalji")]
        public IActionResult Details(int studentId) 
        {
            if (studentId == 1)
            {
                Student student = new Student()
                {
                    Age = 27,
                    FirstName = "John",
                    Id = 1,
                    LastName = "Doe"
                };

                return new JsonResult(student);
            }
            
            return new EmptyResult();
        }

        [HttpPost("Kreiraj")]
        public IActionResult Create([FromBody]Student student) 
        {
            return View();
        }

        [HttpPut("Azuriraj")]
        public IActionResult Update(Student student)
        {
            return View();
        }

        [HttpDelete("Izbrisi")]
        public IActionResult Delete(int studentId)
        {
            return View();
        }
    }
}
