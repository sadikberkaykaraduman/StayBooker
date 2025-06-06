using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StayBooker.RapidApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StayBooker.RapidApi.Controllers
{
    public class BookingByCityController : Controller
    {
        public async Task<IActionResult> Index(string cityId)
        {
            if (!string.IsNullOrEmpty(cityId))
            {
                List<BookingApiViewModel> bookingApiViewModels = new List<BookingApiViewModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?children_number=2&adults_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&checkout_date=2025-10-15&dest_type=city&page_number=0&units=metric&order_by=popularity&room_number=1&checkin_date=2025-10-14&filter_by_currency=AED&dest_id={cityId}&locale=en-gb&include_adjacency=true"),
                    Headers =
    {
        { "x-rapidapi-key", "580342898cmshec2899f1f3dcdebp176b28jsncde4e6b2df78" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.results.ToList());
                }
            }
            else
            {
                List<BookingApiViewModel> bookingApiViewModels = new List<BookingApiViewModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?children_number=2&adults_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&checkout_date=2025-10-15&dest_type=city&page_number=0&units=metric&order_by=popularity&room_number=1&checkin_date=2025-10-14&filter_by_currency=AED&dest_id=-1746443&locale=en-gb&include_adjacency=true"),
                    Headers =
    {
        { "x-rapidapi-key", "580342898cmshec2899f1f3dcdebp176b28jsncde4e6b2df78" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.results.ToList());
                }
            }
        }
    }
}
