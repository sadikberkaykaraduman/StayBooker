using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StayBooker.WebUI.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace StayBooker.WebUI.Controllers
{
    public class AdminDashboardController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
