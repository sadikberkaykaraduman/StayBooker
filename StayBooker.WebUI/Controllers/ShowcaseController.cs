using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StayBooker.WebUI.Dtos.SubscribeDtos;
using StayBooker.WebUI.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace StayBooker.WebUI.Controllers
{
    [AllowAnonymous]
    public class ShowcaseController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ShowcaseController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _ShowcaseSubscribes()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _ShowcaseSubscribes(CreateSubscribeDto createSubscribeDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSubscribeDto);
            var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:44305/api/Subscribes", content);
            return RedirectToAction("Index", "Showcase");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
