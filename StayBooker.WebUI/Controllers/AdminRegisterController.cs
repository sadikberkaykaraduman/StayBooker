using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StayBooker.EntityLayer.Conrete;
using StayBooker.WebUI.Dtos.RegisterDtos;
using System.Threading.Tasks;

namespace StayBooker.WebUI.Controllers
{
    [AllowAnonymous]
    public class AdminRegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminRegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateRegisterDto createRegisterDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = createRegisterDto.Name,
                Email = createRegisterDto.Mail,
                Surname = createRegisterDto.Surname,
                UserName = createRegisterDto.Username
            };
            var result = await _userManager.CreateAsync(appUser, createRegisterDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            return View();
        }
    }
}
