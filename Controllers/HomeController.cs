using Microsoft.AspNetCore.Mvc;

namespace Brittain_Alexander_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Pictures()
        {
            return View();
        }

       
      
        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/Brittain_Alexander_Resume.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "Brittain_Alexander_Resume.pdf");
        }
    }
}
