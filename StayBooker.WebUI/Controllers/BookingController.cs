using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StayBooker.WebUI.Dtos.BookingDtos;
using System.Net.Http;
using System.Threading.Tasks;

namespace StayBooker.WebUI.Controllers
{
    [AllowAnonymous]
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _bookingRezervation()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _bookingRezervation(CreateBookingDto createBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingDto);
            var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:44305/api/Bookings", content);
            return RedirectToAction("Index", "Showcase");
        }
    }
}
