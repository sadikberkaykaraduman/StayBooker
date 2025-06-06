using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page400()
        {
            return View();
        }

        public IActionResult Page403()
        {
            return View();
        }

        public IActionResult Page404()
        {
            return View();
        }

        public IActionResult Page500()
        {
            return View();
        }

        public IActionResult Page503()
        {
            return View();
        }
    }
}
