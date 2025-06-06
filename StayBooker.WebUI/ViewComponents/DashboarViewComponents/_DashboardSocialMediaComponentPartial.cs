using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StayBooker.WebUI.Dtos.FollwersDtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StayBooker.WebUI.ViewComponents.DashboarViewComponents
{
    public class _DashboardSocialMediaComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ResultInstagramFollwersDto resultInstagramFollwersDtos = new ResultInstagramFollwersDto ();
            var client1 = new HttpClient();
            var request1 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/therock"),
                Headers =
    {
        { "x-rapidapi-key", "580342898cmshec2899f1f3dcdebp176b28jsncde4e6b2df78" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response1 = await client1.SendAsync(request1))
            {
                response1.EnsureSuccessStatusCode();
                var body1 = await response1.Content.ReadAsStringAsync();
                resultInstagramFollwersDtos = JsonConvert.DeserializeObject<ResultInstagramFollwersDto>(body1);
                ViewBag.instFollwer = resultInstagramFollwersDtos.followers;
                ViewBag.instFollwing = resultInstagramFollwersDtos.following;
            }


            return View();
        }
    }
}
