using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StayBooker.WebUI.Dtos.StaffDtos;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StayBooker.WebUI.ViewComponents.DashboarViewComponents
{
    public class _DashboardStaffComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardStaffComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44305/api/Staffs/GetLast4Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
