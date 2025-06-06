using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.Controllers
{
    [AllowAnonymous]
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
