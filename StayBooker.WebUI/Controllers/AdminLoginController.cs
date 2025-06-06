using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StayBooker.EntityLayer.Conrete;
using StayBooker.WebUI.Dtos.LoginDto;
using System.Threading.Tasks;

namespace StayBooker.WebUI.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public AdminLoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "AdminDashboard");
                }
            }
            return View();
        }
    }
}
